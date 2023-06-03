//Flights Page
using System;
using System.Data;
using System.Web.UI.HtmlControls;

namespace Odedprojectpleasework
{
    public partial class flights : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* This code is checking if the user is logged in by retrieving the user ID from the session
            variable "user_id". If the user ID is null, meaning the user is not logged in, the code
            redirects the user to an "unreachable" page and stops executing the rest of the code. */

            var userID = Session["user_id"];
            if (userID == null)
            {
                Response.Redirect("unreachable.aspx");
                return;


            }
            /* This code is retrieving flight log data from a database for a specific user. */
            userID = userID.ToString();
            String sql = "select * from FlightLog where UserId = " + userID + " order by [date] desc";
            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);

            /* This code is iterating through each row in a DataTable object called "dt" and creating
            an HTML table row ("tr") for each row in the DataTable. It then populates the table row
            with data from the DataRow object ("dr") using various utility methods from the TblUtils
            class. Finally, it adds a link to another page with more information about the flight
            using the flight ID from the DataRow. */
            foreach (DataRow dr in dt.Rows)
            {
                String notes = dr["Notes"].ToString();
                if (notes.Length > 20)
                {
                    notes = notes.Substring(0, 20) + "...";
                }
                var tr = new HtmlTableRow();
                TblUtils.addTdDate(tr, dr, "Date");
                addTotalFlightTime(tr, dr);
                TblUtils.addTd(tr, dr, "TimeDeparture");
                TblUtils.addTd(tr, dr, "AirDeparture");
                TblUtils.addTd(tr, dr, "TimeLanding");
                TblUtils.addTd(tr, dr, "AirDestination");
                TblUtils.addTd(tr, dr, "Type");
                TblUtils.addTd(tr, dr, "Model");
                TblUtils.addTd(tr, dr, "Callsign");
                TblUtils.addTd(tr, notes, "tdLeft");

                var td = new HtmlTableCell();
                td.InnerHtml = "<a href=\"flight.aspx?id=" + dr["id"] + "\">More</a>";
                tr.Controls.Add(td);
                logbook.Rows.Add(tr);


            }





        }
        /// <summary>
        /// The function adds the total flight time to an HTML table row using a calculated duration
        /// from a data row.
        /// </summary>
        /// <param name="HtmlTableRow">HtmlTableRow is a class in HTML that represents a row in an HTML
        /// table. It is used to create and manipulate rows in an HTML table.</param>
        /// <param name="DataRow">A DataRow is a class in .NET that represents a row of data in a
        /// DataTable. It contains the values of each column in the row. In this context, it is likely
        /// that the DataRow contains information about a flight, such as the departure time and arrival
        /// time.</param>
        void addTotalFlightTime(HtmlTableRow tr, DataRow dr)
        {
            String final = TblUtils.calcDuration(dr);
            TblUtils.addTd(tr, final);

        }
    }
}