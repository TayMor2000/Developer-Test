using System.Web.Mvc;
using MVC_Test.ViewModels;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AddInfoAlert("Hello");
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Hello()
        {
            var model = new HelloViewModel();
            return View(model);
        }
    }
}