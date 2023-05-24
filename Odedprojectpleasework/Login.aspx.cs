using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Odedprojectpleasework
{
    public partial class Login : System.Web.UI.Page
    {
        public String hits = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            



            if (Request.Form["submit"] == null)
            {
                HttpCookie c = Request.Cookies["user_info"];
                if (c == null)
                {
                    return;
                }
                Session["user_id"] = c.Value;
                Response.Redirect("flights.aspx");
            }
            if (Request.Form["submit"] != null)
            {

                //form was submitted
                String database = "Database1.mdf";
                String id = Request.Form["id"];
                String password = Request.Form["password"];
                String query = "select * from Users where id ='" + id + "' and password = '" + password + "'";

                if (!MyAdoHelper.IsExist(database, query))
                {
                    Response.Write("Sorry, your username or password is incorrect");
                }
                else
                {
                    Session["user_id"] = id;
                    HttpCookie userCookie = new HttpCookie("user_info");
                    userCookie.Value = id;
                    Response.Cookies.Add(userCookie);
                    Response.Redirect("flights.aspx");
                }

            }


        }
    }
}