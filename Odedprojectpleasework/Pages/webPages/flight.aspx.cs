using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class flight : System.Web.UI.Page
    {
        public int fligthId;
        protected void Page_Load(object sender, EventArgs e)
        {
            var userId = Session["user_id"];

            if(userId == null)
            {
                Response.Redirect("unreachable.aspx");
                return;
            }

            userId = userId.ToString();
            try
            {
                fligthId = int.Parse(Request.QueryString["id"]);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return;
            }
            var act = Request.QueryString["action"];
            if(act != null && act == "del")
            {
                String delSQL = "delete from FlightLog where id=" + fligthId + " and UserId = " + userId;
                MyAdoHelper.ExecuteNonQuery("Database1.mdf", delSQL);
                Response.Redirect("flights.aspx");
            }


            String sql = "select * from FlightLog where id=" + fligthId + " and UserId = " + userId;

            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);
            if(dt.Rows.Count == 0) {
                Response.Redirect("flights.aspx");
                return;
            }
            populateData(userId.ToString(), fligthId);

        }


        void populateData(String userId, int flightId)
        {
            String sql = "select * from FlightLog where id=" + flightId + " and UserId = " + userId;

            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);
            if (dt.Rows.Count == 0)
            {
                Response.Redirect("flights.aspx");
                return;
            }
            var flightDate = dt.Rows[0]["Date"];
            var notes = dt.Rows[0]["Notes"].ToString();
            var takeoff = dt.Rows[0]["AirDeparture"].ToString();
            var destination = dt.Rows[0]["AirDestination"].ToString();
            var model = dt.Rows[0]["Model"].ToString();
            var callsign = dt.Rows[0]["Callsign"].ToString();
            var d = DateTime.Parse(flightDate.ToString());
            var flightDuration = TblUtils.calcDuration(dt.Rows[0]);
            this.flightDate.InnerText = d.ToLongDateString();
            this.notes.InnerText = notes;
            this.airportTakeoff.InnerText = takeoff;
            this.airportLanding.InnerText = destination;
            this.model.InnerText = model;
            this.callsign.InnerText = callsign;
            this.duration.InnerText = flightDuration;
        }
    }
}