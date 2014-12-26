using System.Web.Mvc;

namespace ProjectTwo.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Title = "Home Page";
            return PartialView();
        }
    }
}