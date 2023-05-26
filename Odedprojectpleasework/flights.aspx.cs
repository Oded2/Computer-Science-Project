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
                TblUtils.addTd(tr, dr, "Notes");
                logbook.Rows.Add(tr);


            }





        }
        void addTotalFlightTime(HtmlTableRow tr, DataRow dr)
        {
            var d =  DateTime.Parse( dr["Date"].ToString());
            var t1 = dr["TimeDeparture"].ToString();
            var t2 = dr["TimeLanding"].ToString();
            var d1 = d + TimeSpan.Parse(t1);
            var d2 = d + TimeSpan.Parse(t2);
            var ts = d2 - d1;
            if (ts.TotalSeconds < 0)
            {
                d1 = d1.AddDays(-1);
                ts = d2 - d1;
            }
            String final;
            if (ts.Minutes == 0)
            {
                final = (int)ts.TotalHours + " Hours";
            }
            else
            {
                final = (int)ts.TotalHours + " Hours and " + ts.Minutes + " Minutes";
            }
            TblUtils.addTd(tr, final);

        }
    }
}