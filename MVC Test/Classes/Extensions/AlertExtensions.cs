using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Classes.Extensions
{
    public static class AlertExtensions
    {
        public static IHtmlString Alerts(this HtmlHelper helper)
        {
            var alerts = helper.ViewContext.TempData.Get<Alerts>();
            return alerts ?? (IHtmlString)MvcHtmlString.Empty;
        }
    }
}