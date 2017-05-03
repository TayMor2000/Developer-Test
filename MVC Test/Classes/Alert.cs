using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Classes
{
    public class Alert : IHtmlString
    {
        public enum AlertStatus
        {
            Success,
            Danger,
            Info,
            Warning
        }

        private readonly bool _dismissable;

        public Alert(string message, bool dismissable = true)
        {
            _dismissable = dismissable;
            Message = message;
        }

        public string Message { get; private set; }

        public AlertStatus Status { get; set; }

        public string ToHtmlString()
        {
            var tag = new TagBuilder("div");
            var innerTag = new TagBuilder("div");
            var button = new TagBuilder("button");
            button.AddCssClass("close");
            button.MergeAttribute("data-dismiss", "alert");
            button.MergeAttribute("aria-hidden", "true");
            button.InnerHtml = "&times;";

            tag.AddCssClass("alert");
            innerTag.AddCssClass("alert-inner");

            switch (Status)
            {
                case AlertStatus.Success:
                    tag.AddCssClass("alert-success");
                    break;
                case AlertStatus.Warning:
                    tag.AddCssClass("alert-warning");
                    break;
                case AlertStatus.Danger:
                    tag.AddCssClass("alert-danger");
                    break;
                case AlertStatus.Info:
                    tag.AddCssClass("alert-info");
                    break;
            }

            if (_dismissable)
            {
                tag.AddCssClass("alert-dismissable");
                tag.InnerHtml = button.ToString();
            }

            innerTag.InnerHtml += Message;
            tag.InnerHtml += innerTag;

            return tag.ToString();
        }
    }
}