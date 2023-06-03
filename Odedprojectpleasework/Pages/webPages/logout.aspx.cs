//Logout Page
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* This code is used to clear the session and delete the user_info cookie. It is typically
            used when a user logs out of a website. */
            Session.Clear();
            HttpCookie c = Request.Cookies["user_info"];
            if (c != null)
            {
                Response.Cookies["user_info"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("login.aspx");
        }
    }
}