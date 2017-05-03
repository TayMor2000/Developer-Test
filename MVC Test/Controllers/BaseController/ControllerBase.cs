using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.Classes;
using MVC_Test.Classes.Extensions;

namespace MVC_Test.Controllers.BaseController
{
    public class MyControllerBase : Controller
    {

        protected void AddAlert(Alert alert)
        {
            var alerts = TempData.Get<Alerts>() ?? new Alerts();
            alerts.Add(alert);
            TempData.Put(alerts);
        }

        protected void AddErrorAlert(string message)
        {
            AddAlert(new Alert(message) { Status = Alert.AlertStatus.Danger });
        }

        protected void AddErrorAlertFormat(string message, params object[] args)
        {
            AddAlert(new Alert(string.Format(message, args)) { Status = Alert.AlertStatus.Danger });
        }

        protected void AddInfoAlert(string message)
        {
            AddAlert(new Alert(message) { Status = Alert.AlertStatus.Info });
        }

        protected void AddInfoAlertFormat(string message, params object[] args)
        {
            AddAlert(new Alert(string.Format(message, args)) { Status = Alert.AlertStatus.Info });
        }

        protected void AddSuccessAlert(string message)
        {
            AddAlert(new Alert(message) { Status = Alert.AlertStatus.Success });
        }

        protected void AddWarningAlert(string message)
        {
            AddAlert(new Alert(message) { Status = Alert.AlertStatus.Warning });
        }

    }
}