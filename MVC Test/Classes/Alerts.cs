using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MVC_Test.Classes
{
    public class Alerts : IEnumerable<Alert>, IHtmlString
    {
        private readonly IList<Alert> _alerts = new List<Alert>();

        public int Count
        {
            get { return _alerts.Count; }
        }

        public void Add(Alert item)
        {
            _alerts.Add(item);
        }

        public IEnumerator<Alert> GetEnumerator()
        {
            return _alerts.GetEnumerator();
        }

        public string ToHtmlString()
        {
            return _alerts.Aggregate(new StringBuilder(), (builder, alert) => builder.Append(alert.ToHtmlString())).ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}