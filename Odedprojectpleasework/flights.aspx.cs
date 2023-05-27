using System;
using System.Data;
using System.Web.UI.HtmlControls;

namespace Odedprojectpleasework
{
    public partial class flights : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var userID = Session["user_id"];
            if (userID == null)
            {
                Response.Redirect("unreachable.aspx");
                return;


            }
            userID = userID.ToString();
            String sql = "select * from FlightLog where UserId = " + userID + " order by [date] desc";
            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);

            foreach (DataRow dr in dt.Rows)
            {
                String notes = dr["Notes"].ToString();
                if(notes.Length > 20)
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
                TblUtils.addTd(tr,notes, "tdLeft");
                
                var td = new HtmlTableCell();
                td.InnerHtml = "<a href=\"flight.aspx?id=" + dr["id"] + "\">More</a>";
                tr.Controls.Add(td);
                logbook.Rows.Add(tr);


            }





        }
        void addTotalFlightTime(HtmlTableRow tr, DataRow dr)
        {
            String final = TblUtils.calcDuration(dr);
            TblUtils.addTd(tr, final);

        }
    }
}