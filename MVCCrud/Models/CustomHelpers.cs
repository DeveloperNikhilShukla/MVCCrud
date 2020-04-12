using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.Models
{
    public static class CustomHelpers
    {
        public static IHtmlString image(string src, string alt)
        {
            return new MvcHtmlString(string.Format("'<img src={0}>' alt={1}", src, alt));
        }


        public static IHtmlString File(this HtmlHelper helper, string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new MvcHtmlString(tb.ToString());
        }


        public static IHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            // Build <img> tag. The parameter name must be img 
            TagBuilder tb = new TagBuilder("img");
            // Add "src" attribute
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            // Add "alt" attribute
            tb.Attributes.Add("alt", alt);
            // return MvcHtmlString. This class implements IHtmlString
            // interface. IHtmlStrings will not be html encoded.
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));

        }
    }
    } 