using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




            /* This code block is checking if the form has been submitted or not. If the form has not
            been submitted, it checks if there is a cookie named "user_info". If the cookie exists,
            it retrieves the user's information from the database and sets the session variables
            accordingly. If the user is an admin, it sets the "is_admin" session variable to "yes".
            Finally, it redirects the user to the "flights.aspx" page. */
            if (Request.Form["submit"] == null)
            {
                HttpCookie c = Request.Cookies["user_info"];
                if (c == null)
                {
                    return;
                }
                String sql = "select * from Users where id ='" + c.Value + "'";
                var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                var dr = dt.Rows[0];
                var isAdmin = bool.Parse("" + dr["isAdmin"]);
                Session["user_id"] = c.Value;
                if (isAdmin)
                {
                    Session["is_admin"] = "yes";
                }
                Response.Redirect("flights.aspx");
            }
            /* This code block is checking if the login form has been submitted or not. If the form has
            been submitted, it retrieves the user's inputted ID and password from the form. It then
            queries the database to check if there is a matching user with the inputted ID and
            password. If there is no matching user, it displays an error message. If there is a
            matching user, it sets the session variables for the user's ID and whether or not they
            are an admin. It also creates a cookie named "user_info" with the user's ID and adds it
            to the response. Finally, it redirects the user to the "flights.aspx" page. */
            if (Request.Form["submit"] != null)
            {

                //form was submitted
                String id = Request.Form["id"].Replace("'", "''");
                String password = Request.Form["password"].Replace("'", "''");
                String sql = "select * from Users where id ='" + id + "' and password = '" + password + "'";
                var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);
                if (dt.Rows.Count == 0)
                {
                    Response.Write("Sorry, your username or password is incorrect");
                    return;
                }
                else
                {
                    var dr = dt.Rows[0];
                    var isAdmin = bool.Parse("" + dr["isAdmin"]);
                    Session["user_id"] = id;
                    if (isAdmin)
                    {
                        Session["is_admin"] = "yes";
                    }

                    HttpCookie userCookie = new HttpCookie("user_info")
                    {
                        Value = id
                    };
                    Response.Cookies.Add(userCookie);
                    Response.Redirect("flights.aspx");
                }
            }


        }
    }
}