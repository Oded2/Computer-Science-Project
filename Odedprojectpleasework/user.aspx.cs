using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class user : System.Web.UI.Page
    {
        int editId;
        String userId;
        bool isSameUser = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null || Session["is_admin"] == null)
            {
                Response.Redirect("unreachable.aspx");
            }
            userId = Session["user_id"].ToString();

            try
            {
                editId = int.Parse(Request.QueryString["id"]);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return;
            }
            isSameUser = (editId.ToString() == userId); 
            if (!IsPostBack)
            {
                populateData();
                if (isSameUser)
                {
                    this.isAdmin.Disabled = true;
                    this.userDel.Disabled = true;
                }
                return;
            }
            if (userDel.Checked)
            {
                deleteUser();
                return;
            }
            updateData();

        }
        private void deleteUser()
        {
            String sql = "delete from Flightlog where UserId=" + editId;
            MyAdoHelper.ExecuteNonQuery("Database1.mdf",sql);
            sql = "delete from Users where id=" + editId;
            MyAdoHelper.ExecuteNonQuery("Database1.mdf", sql);
            Response.Redirect("admin.aspx");

        }
        private void updateData()
        {
            String sql = "Update Users set ";
            sql += "password='" + this.password.Value.Replace("'", "''") + "', ";
            sql += "fname='" + this.fname.Value.Replace("'", "''") + "', ";
            sql += "lName='" + this.lname.Value.Replace("'", "''") + "', ";
            sql += "dob='" + this.dob.Value.Replace("'", "''") + "', ";
            sql += "gpa=" + this.gpa.Value + ", ";
            sql += "email='" + this.email.Value.Replace("'", "''") + "', ";
            sql += "address='" + this.address.Value.Replace("'", "''") + "', ";
            sql += "tel='" + this.tel.Value.Replace("'", "''") + "', ";
            sql += "spam='" + this.spam.Checked.ToString() + "', ";
            sql += "isAdmin='" + this.isAdmin.Checked.ToString() + "' ";
            sql += "where id=" + editId;
            MyAdoHelper.ExecuteNonQuery("Database1.mdf", sql);
            Response.Redirect("admin.aspx");
            return;

        }


        private void populateData()
        {
            String sql = "Select * from Users where id =" + editId;
            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);
            if (dt.Rows.Count == 0)
            {
                Response.Redirect("admin.aspx");
                return;
            }
            var dr = dt.Rows[0];
            this.spnUserid.InnerText = "" + dr["Id"];
            this.password.Value = "" + dr["password"];
            this.fname.Value = "" + dr["fname"];
            this.lname.Value = "" + dr["lName"];
            var temp = dr["dob"];
            if (temp!= null)
            {
                var d = DateTime.Parse(temp.ToString());
                this.dob.Value = d.ToString("yyyy-MM-dd");
            }
            
            this.gpa.Value = "" + dr["gpa"];
            this.email.Value = "" + dr["email"];
            this.address.Value = "" + dr["address"];
            this.tel.Value = "" + dr["tel"];
            this.spam.Checked = bool.Parse("" + dr["spam"]);
            this.isAdmin.Checked = bool.Parse("" + dr["isAdmin"]);

        }
    }
}