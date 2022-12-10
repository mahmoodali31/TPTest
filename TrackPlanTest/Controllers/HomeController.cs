using System.Web.Mvc;
using TrackPlanTest.Models;

namespace TrackPlanTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DiagonalRow(TrackPlanModel model)
        {
            return View(model) ;
        }
    }
}