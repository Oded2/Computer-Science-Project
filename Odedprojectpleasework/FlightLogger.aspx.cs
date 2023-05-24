using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class flightlogger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] == null)
            {
                return;
            }
            String date = Request.Form["logDate"];
            String id = Request.Form["LogID"];
            String takeoff = Request.Form["logTakeoff"];
            String departure = Request.Form["logAirportTakeoff"];
            String landing = Request.Form["logLanding"];
            String destination = Request.Form["logAirportLanding"];
            String type = Request.Form["logAirType"];
            String model = Request.Form["logModel"];
            String notes = Request.Form["logNotes"];

            Response.Write(date);


            Response.Write(id);


        }
    }
}