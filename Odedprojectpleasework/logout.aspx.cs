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