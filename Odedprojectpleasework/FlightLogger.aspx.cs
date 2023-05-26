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

            var userID = Session["user_id"];
            if(userID == null)
            {
                Response.Redirect("unreachable.aspx");
                return;
            }
            userID = userID.ToString();

            if (Request.Form["submit"] == null)
            {
                return;
            }
            String date = Request.Form["logDate"];
            String callsign = Request.Form["callsign"];
            String takeoff = Request.Form["logTakeoff"];
            String departure = Request.Form["logAirportTakeoff"];
            String landing = Request.Form["logLanding"];
            String destination = Request.Form["logAirportLanding"];
            String airType = Request.Form["logAirType"];
            String model = Request.Form["logModel"];
            String notes = Request.Form["logNotes"];
            var sb = new StringBuilder();
            sb.Append("insert into FlightLog([UserId], [Date],[Callsign],[TimeDeparture],[AirDeparture],[TimeLanding] ,[AirDestination],[Type], [Model], [Notes]) values(");
            sb.Append(userID);
            sb.Append(",'" + date + "',");
            sb.Append("'" + callsign + "',");
            sb.Append("'" + takeoff+ "',");
            sb.Append("'" + departure+ "',");
            sb.Append("'" + landing+ "',");
            sb.Append("'" + destination + "',");
            sb.Append("'" + airType + "',");
            sb.Append("'" + model+ "',");
            sb.Append("'" + notes + "'");
            sb.Append(")");
            String sql = sb.ToString();
            int rowsAffected = MyAdoHelper.DoQuery("Database1.mdf", sql);
            Response.Redirect("flights.aspx");



        }
    }
}