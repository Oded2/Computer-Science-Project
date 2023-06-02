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
            /* This code is checking if the user is logged in and has the necessary session variables
            set. If either the "user_id" or "is_admin" session variables are null, the user is
            redirected to an "unreachable" page, indicating that they do not have access to the
            current page. */
            if (Session["user_id"] == null || Session["is_admin"] == null)
            {
                Response.Redirect("unreachable.aspx");
            }
            /* `userId = Session["user_id"].ToString();` is retrieving the value of the "user_id"
            session variable and storing it in the `userId` variable as a string. The session
            variable is likely set when the user logs in and is used to identify the current user
            throughout their session. */
            userId = Session["user_id"].ToString();

            /* This code is attempting to parse the value of the "id" parameter from the query string
            of the current URL as an integer and store it in the `editId` variable. If the parsing
            fails, an exception is caught and the error message is written to the response, and the
            function returns. */
            try
            {
                editId = int.Parse(Request.QueryString["id"]);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return;
            }
            /* This code is handling the logic for editing and updating user data in a web application. */
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
            /* This code is deleting a user's data from two tables in a database. The first SQL
            statement deletes all records from the "Flightlog" table where the "UserId" column
            matches the value of the "editId" variable. The second SQL statement deletes the user's
            record from the "Users" table where the "id" column matches the value of the "editId"
            variable. Finally, the user is redirected to the "admin.aspx" page. */
            String sql = "delete from Flightlog where UserId=" + editId;
            MyAdoHelper.ExecuteNonQuery("Database1.mdf", sql);
            sql = "delete from Users where id=" + editId;
            MyAdoHelper.ExecuteNonQuery("Database1.mdf", sql);
            Response.Redirect("admin.aspx");

        }
        private void updateData()
        {
            /* This code is updating user data in a database table called "Users". The SQL statement is
            constructed by concatenating strings to form the complete query. The values of various
            form fields are used to update the corresponding columns in the table. The `Replace("'",
            "''")` method is used to escape any single quotes in the form field values to prevent
            SQL injection attacks. The `MyAdoHelper.ExecuteNonQuery` method is used to execute the
            SQL statement and update the database. Finally, the user is redirected to the
            "admin.aspx" page. */
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
            /* This code is retrieving user data from a database table called "Users" based on the
            value of the "id" column matching the value of the "editId" variable. The SQL statement
            is constructed by concatenating strings to form the complete query. The
            `MyAdoHelper.ExecuteDataTable` method is used to execute the SQL statement and retrieve
            the data as a DataTable object. If the DataTable has no rows, the user is redirected to
            the "admin.aspx" page. Otherwise, the first row of the DataTable is retrieved and its
            values are used to populate various form fields on the web page. The `DateTime.Parse`
            method is used to convert the value of the "dob" column to a DateTime object, which is
            then formatted as a string and assigned to the "dob" form field. The values of the
            "spam" and "isAdmin" columns are parsed as booleans and used to set the checked state of
            corresponding checkboxes on the web page. */
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
            if (temp != null)
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