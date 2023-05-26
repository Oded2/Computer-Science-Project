using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

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
                addTdDate(tr, dr, "Date");
                addTotalFlightTime(tr, dr);
                addTd(tr, dr, "TimeDeparture");
                addTd(tr, dr, "AirDeparture");
                addTd(tr, dr, "TimeLanding");
                addTd(tr, dr, "AirDestination");
                addTd(tr, dr, "Type");
                addTd(tr, dr, "Model");
                addTd(tr, dr, "Callsign");
                addTd(tr, dr, "Notes");
                logbook.Rows.Add(tr);


            }





        }
        void addTd(HtmlTableRow tr, String value)
        {
            var td = new HtmlTableCell();
            td.InnerText = value;
            tr.Cells.Add(td);
        }
        void addTd(HtmlTableRow tr, DataRow dr, String fieldName)
        {
            addTd(tr, dr[fieldName].ToString());
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

            addTd(tr, final);

        }
        void addTdDate(HtmlTableRow tr, DataRow dr, String fieldName){
            var p = dr[fieldName];
            var d = DateTime.Parse(p.ToString());
            addTd(tr, d.ToString("dd/MM/yyyy"));
        }
    }
}