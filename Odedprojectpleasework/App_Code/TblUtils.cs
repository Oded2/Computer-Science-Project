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
        var td = new HtmlTableCell();
        td.InnerText = value;
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


}