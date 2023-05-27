using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var userID = Session["user_id"];
            //if (userID == null)
            //{
            //    Response.Redirect("unreachable.aspx");
             //   return;


            //}
            String sql = "select * from Users order by Id";
            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);

            foreach (DataRow dr in dt.Rows)
            {
             
                var tr = new HtmlTableRow();
                TblUtils.addTd(tr, dr, "Id");
                TblUtils.addTd(tr, dr, "fname");

                TblUtils.addTd(tr, dr, "lName");
                TblUtils.addTd(tr, dr, "tel");
                TblUtils.addTd(tr, dr, "address");
                TblUtils.addTd(tr, dr, "dob");
                TblUtils.addTd(tr, dr, "gpa");
                TblUtils.addTd(tr, dr, "email");
                TblUtils.addTd(tr, dr, "spam");

                var td = new HtmlTableCell();
                td.InnerHtml = "<a href=\"user.aspx?id=" + dr["id"] + "\">Edit</a>";
                tr.Controls.Add(td);
                tblUsers.Rows.Add(tr);


            }
        }
    }
}