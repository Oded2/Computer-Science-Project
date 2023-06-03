//Flight Logger Page
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Odedprojectpleasework
{
    public partial class flightlogger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* This code block is checking if the current request is a postback or not. If it is not a
            postback, it loads an XML file containing airport codes and names, and adds them as
            options to two dropdown lists (`logAirportTakeoff` and `logAirportLanding`) on the web
            page. This is likely done to allow the user to select the airports they are departing
            from and arriving at when logging a flight. */
            if (!IsPostBack)
            {
                var fileLocation = Server.MapPath("~/App_Data/airports.xml");
                var doc = new XmlDocument();
                doc.Load(fileLocation);
                foreach (XmlNode node in doc.DocumentElement)
                {
                    var code = node.SelectSingleNode("code").InnerText;
                    var name = node.SelectSingleNode("name").InnerText;
                    ListItem item = new ListItem(name, code);
                    this.logAirportTakeoff.Items.Add(item);
                    this.logAirportLanding.Items.Add(item);
                }

            }

            /* This code block is checking if the `user_id` key exists in the `Session` object. If it
            does not exist, the user is redirected to the `unreachable.aspx` page and the function
            returns. This is likely done to ensure that only authenticated users can access the
            functionality of this page. */
            var userID = Session["user_id"];
            if (userID == null)
            {
                Response.Redirect("unreachable.aspx");
                return;
            }
            userID = userID.ToString();

            /* This code block is checking if the form has been submitted or not. If the `submit` key
            does not exist in the `Request.Form` object, it means that the form has not been
            submitted yet, so the function returns without doing anything. This is likely done to
            prevent the code from executing prematurely before the user has submitted the form. */
            if (Request.Form["submit"] == null)
            {
                return;
            }
            /* This code block is retrieving data from the form submitted by the user and constructing
            an SQL query to insert the data into a database table called `FlightLog`. The
            `StringBuilder` object is used to construct the SQL query string, which includes the
            user ID, date, callsign, departure and arrival airports, aircraft type and model, and
            any notes provided by the user. The `MyAdoHelper.DoQuery` method is then used to execute
            the SQL query and insert the data into the database. Finally, the user is redirected to
            the `flights.aspx` page. */
            String date = Request.Form["logDate"];
            String callsign = Request.Form["callsign"];
            String takeoff = Request.Form["logTakeoff"];
            String departure = this.logAirportTakeoff.Value;
            String landing = Request.Form["logLanding"];
            String destination = this.logAirportLanding.Value;
            String airType = Request.Form["logAirType"];
            String model = Request.Form["logModel"];
            String notes = Request.Form["logNotes"];
            var sb = new StringBuilder();
            sb.Append("insert into FlightLog([UserId], [Date],[Callsign],[TimeDeparture],[AirDeparture],[TimeLanding] ,[AirDestination],[Type], [Model], [Notes]) values(");
            sb.Append(userID);
            sb.Append(",'" + date + "',");
            sb.Append("'" + callsign.Replace("'", "''") + "',");
            sb.Append("'" + takeoff + "',");
            sb.Append("'" + departure + "',");
            sb.Append("'" + landing + "',");
            sb.Append("'" + destination + "',");
            sb.Append("'" + airType + "',");
            sb.Append("'" + model.Replace("'", "''") + "',");
            sb.Append("'" + notes.Replace("'", "''") + "'");
            sb.Append(")");
            String sql = sb.ToString();
            int rowsAffected = MyAdoHelper.DoQuery("Database1.mdf", sql);
            Response.Redirect("flights.aspx");




        }
    }
}