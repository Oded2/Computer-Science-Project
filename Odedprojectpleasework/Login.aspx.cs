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
            if (Request.Form["submit"] != null)
            {

                //form was submitted
                String id = Request.Form["id"];
                String password = Request.Form["password"];
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