  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

            Application.Lock();
            if (Application["hits"] != null)
            {
                Application["hits"] = (int)Application["hits"] + 1;
                
            }
            else
            {
                Application["hits"] = 1;
            }
            Application.UnLock();
            object userID = Session["user_id"];
            if (userID == null)
            {
                Response.Write(@"Please <a href=""login.aspx"">Login</a>");
                Response.Redirect("Login.aspx");
            }
            else
            {
                var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", "SELECT fname from Users where id=" + userID);
                var fname = dt.Rows[0]["fname"].ToString();
                username.InnerText = fname;
                tdHeader3.InnerHtml = "<a href=\"logout.aspx\">Logout</a>";
            }


        }
    }
}