using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3
{
    public static class CustomHelper
    {
        public static IHtmlString ImageHelper(string src,string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'> </img>", src, alt));
        }
        public static IHtmlString ImageHelperNew(this HtmlHelper htmlHelper, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'> </img>", src, alt));
        }
        public static IHtmlString ImageHelperWithTag(this HtmlHelper htmlHelper, string src, string alt)
        {
            TagBuilder t = new TagBuilder("img");
            t.Attributes.Add("src",src);
            t.Attributes.Add("alt", alt);

            return new MvcHtmlString(t.ToString());
        }
    }
}