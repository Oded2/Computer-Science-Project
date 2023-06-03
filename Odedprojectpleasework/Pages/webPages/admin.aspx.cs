//Admin Page
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
        String userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            /* This code is checking if the user is logged in and if they have admin privileges. If
            either of these conditions is not met, the user is redirected to an "unreachable" page.
            If both conditions are met, the user's ID is stored in the `userId` variable for later
            use. */
            if (Session["user_id"] == null || Session["is_admin"] == null)
            {
                Response.Redirect("unreachable.aspx");
            }
            userId = Session["user_id"].ToString();
            /* This code is selecting all columns from the "Users" table in the "Database1.mdf"
            database and ordering the results by the "Id" column. The results are then stored in a
            DataTable object named "dt" using the MyAdoHelper.ExecuteDataTable method. */
            String sql = "select * from Users order by Id";
            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);

            /* This code is iterating through each row in the DataTable object `dt` and creating a new
            HTML table row (`HtmlTableRow`) for each row in the table. For each column in the row,
            it is adding a new HTML table cell (`HtmlTableCell`) using the `TblUtils.addTd` method,
            which takes the current row (`tr`), the current row's data (`dr`), and the name of the
            column to add as parameters. */
            foreach (DataRow dr in dt.Rows)
            {

                var tr = new HtmlTableRow();
                TblUtils.addTd(tr, dr, "Id");
                TblUtils.addTd(tr, dr, "fname");
                TblUtils.addTd(tr, dr, "lName");
                TblUtils.addTd(tr, dr, "tel");
                TblUtils.addTd(tr, dr, "address");
                TblUtils.addTdDate(tr, dr, "dob");
                TblUtils.addTd(tr, dr, "gpa");
                TblUtils.addTd(tr, dr, "email");
                TblUtils.addTd(tr, dr, "spam");
                TblUtils.addTd(tr, dr, "isAdmin");

                var td = new HtmlTableCell();
                td.InnerHtml = "<a href=\"user.aspx?id=" + dr["id"] + "\">Edit</a>";
                tr.Controls.Add(td);
                tblUsers.Rows.Add(tr);


            }
        }
    }
}
