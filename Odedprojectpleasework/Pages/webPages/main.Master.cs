//Master Page
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected String userID { get; set; } = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            /* This code checks if the session variable "user_id" is not null. If it is not null, it
            sets the value of the protected property "userID" to the string value of the session
            variable "user_id". It also changes the text and href attributes of an HTML anchor
            element with the ID "loginHref" to "Logout" and "logout.aspx" respectively. This
            suggests that the code is likely used to handle user authentication and display the
            appropriate login/logout links on the web page. */
            if (Session["user_id"] != null)
            {
                userID = Session["user_id"].ToString();
                loginHref.InnerText = "Logout";
                loginHref.HRef = "logout.aspx";
            }
        }
    }
}
