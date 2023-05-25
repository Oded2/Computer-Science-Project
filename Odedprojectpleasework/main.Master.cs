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
            if (Session["user_id"] != null) {
                userID = Session["user_id"].ToString();
                loginHref.InnerText = "Logout";
                loginHref.HRef = "logout.aspx";
            }
        }
    }
    }
