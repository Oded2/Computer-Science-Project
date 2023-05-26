using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace Odedprojectpleasework
{
    public partial class airports : System.Web.UI.Page
    {
        String userId = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"]  != null)
            {
                this.userId = Session["user_id"].ToString();
            }

            var fileLocation = Server.MapPath("~/App_Data/airports.xml");
            var doc = new XmlDocument();
            doc.Load(fileLocation);

            var wrapper = HtmlUtils.CreateDiv(null, "flex-container");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                String name = node.SelectSingleNode("name").InnerText;
                String code = node.SelectSingleNode("code").InnerText;
                String location = node.SelectSingleNode("location").InnerText;
                String description = node.SelectSingleNode("description").InnerText;
                int totalFlights = CountFlight(code);
                var d = HtmlUtils.CreateDiv();
                var d1 = HtmlUtils.CreateDiv(null, "nameWrapper");
                d1.Controls.Add(HtmlUtils.CreateDiv(name, "airportName"));
                d1.Controls.Add(HtmlUtils.CreateDiv(code, "airportCode"));
                d.Controls.Add(d1);
                d.Controls.Add(HtmlUtils.CreateDiv(location, "airportLoc"));
                d.Controls.Add(HtmlUtils.CreateDiv(description, "airportDesc"));

                var s = "You never used this airport";
                if (totalFlights == -1)
                {
                    s = "Please login for flight info";
                }
                if (totalFlights > 0)
                {
                    s = "You used this airport " + totalFlights + " times";
                }
                d.Controls.Add(HtmlUtils.CreateDiv(s, "airportUsed"));
                wrapper.Controls.Add(d);
            }
            this.airportWrapper.Controls.Add(wrapper);


        }

        private int CountFlight(String code)
        {

            if (this.userId == null)
            {
                return -1;
            }


            String sql = "select count(*) from FlightLog where UserId = " + this.userId + " and AirDeparture = '" + code + "' or AirDestination = '" + code + "'";
            var dt = MyAdoHelper.ExecuteDataTable("Database1.mdf", sql);
            return (int)dt.Rows[0][0];
        }
    }
}