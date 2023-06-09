﻿//Signup Page
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class signup : System.Web.UI.Page
    {
        /*       protected void Page_Load(object sender, EventArgs e)
               {
                   myTime = DateTime.Now;
               }*/

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Form["submit"] != null)
            {

                String errMessage = "";
                divError.Visible = false;
                try
                {

                    String id = Request.Form["id"];
                    String query = "SELECT * from Users where Users.Id = '" + id + "'";
                    if (MyAdoHelper.IsExist("Database1.mdf", query))
                    {
                        errMessage = "ID already in use";
                    }
                    String fname = Request.Form["fname"];
                    String lname = Request.Form["lname"];
                    String tel = Request.Form["tel"];
                    String address = Request.Form["address"];
                    String dob = Request.Form["dob"];
                    float gpa = 0;
                    try
                    {
                        gpa = float.Parse(Request.Form["gpa"]);
                    }
                    catch (Exception)
                    {
                        errMessage = "GPA must be a number";
                    }

                    String email = Request.Form["email"];
                    String spam = Request.Form["spam"];
                    String password = Request.Form["password"];
                    int isSpam = 0;
                    if (spam == "on")
                    {
                        isSpam = 1;
                    }
                    if (errMessage == "")
                    {


                        String sql = "insert into Users values('" +
                            id.Replace("'", "''") +
                            "',N'" + fname.Replace("'", "''") +
                            "',N'" + lname.Replace("'", "''") +
                            "',N'" + tel.Replace("'", "''") +
                            "',N'" + address.Replace("'", "''") + "'," +
                            "'" + dob.Replace("'", "''") + "'," +
                            gpa +
                            ",'" + email.Replace("'", "''") + "','" +
                            isSpam +
                            "', '" + password.Replace("'", "''") +
                            "', 0)";
                        int rowsAffected = MyAdoHelper.DoQuery("Database1.mdf", sql);
                        if (rowsAffected == 0)
                        {
                            errMessage = errMessage + "<br>" + "Could not create row in the database";
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
                catch (Exception ex)
                {
                    errMessage = errMessage + "<br>" + ex.Message;
                }
                if (errMessage != "")
                {
                    divError.Visible = true;
                    divError.InnerHtml = errMessage;
                }

            }
        }
    }
}
