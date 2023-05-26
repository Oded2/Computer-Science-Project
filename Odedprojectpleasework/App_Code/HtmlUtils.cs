using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

public class HtmlUtils
{
    public static HtmlGenericControl CreateDiv()
    {
        return CreateDiv(null, null);
    }
    public static HtmlGenericControl CreateDiv(String content)
    {
        return CreateDiv(content, null);
    }
    public static HtmlGenericControl CreateDiv(String content, String className)
    {
        var div = new HtmlGenericControl("div");
        if (!String.IsNullOrEmpty(className))
        {
            div.Attributes["class"] = className;
        }
        if (!String.IsNullOrEmpty(content)) {
            div.InnerText = content;
        }
        return div;
    }
}
