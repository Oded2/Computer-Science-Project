using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odedprojectpleasework
{
    public partial class index1 : System.Web.UI.Page
    {
        public int totalVisits;
        protected void Page_Load(object sender, EventArgs e)
        {
            var p = Application["hits"];
            if(p == null)
            {
                totalVisits = 0;
            }
            else
            {
                totalVisits = int.Parse(p.ToString());
            }
            totalVisits++;
            Application["hits"] = totalVisits;
        }
    }
}