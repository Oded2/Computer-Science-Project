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
            /* This code is retrieving the value of the "hits" key from the Application object, which
            is a global object that can be accessed by all users of the application. If the "hits"
            key does not exist, it sets the totalVisits variable to 0. If the "hits" key does exist,
            it parses the value to an integer and sets the totalVisits variable to that value. It
            then increments the totalVisits variable by 1 and sets the "hits" key in the Application
            object to the new value. This code is used to keep track of the number of times the page
            has been visited by all users of the application. */
            var p = Application["hits"];
            if (p == null)
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