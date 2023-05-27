using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

public class TblUtils

{
    public static void addTd(HtmlTableRow tr, String value)
    {
        addTd(tr, value, null);
    }
    public static void addTd(HtmlTableRow tr, String value, String className)
    {


        var td = new HtmlTableCell();
        td.InnerText = value;
        if (className != null)
        {
            td.Attributes["class"] = className;
        }
        tr.Cells.Add(td);
    }
    public static void addTd(HtmlTableRow tr, DataRow dr, String fieldName)
    {
        addTd(tr, dr[fieldName].ToString());
    }
    public static void addTdDate(HtmlTableRow tr, DataRow dr, String fieldName)
    {
        var p = dr[fieldName];
        var d = DateTime.Parse(p.ToString());
        addTd(tr, d.ToString("dd/MM/yyyy"));
    }
    public static String calcDuration(DataRow dr)
    {
        var d = DateTime.Parse(dr["Date"].ToString());
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
        return final;
    }


}