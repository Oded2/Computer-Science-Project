using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object userID = Session["user_id"];
            if (userID != null) {
                tdHeader3.InnerHtml = "<a href=\"logout.aspx\">Logout</a>";
            }
            else
            {
                tdHeader1.InnerHtml = "<a href=\"Login.aspx\"> Log In </a>";
            }
        }
    }
}