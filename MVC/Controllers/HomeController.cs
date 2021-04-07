using BlackLight.Recruitment.MVC.Models;
using System.Web.Mvc;

namespace BlackLight.Recruitment.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View(new ContactUsViewModel());
        }

        [HttpPost]
        public ActionResult Contact(ContactUsViewModel data)
        {
            TempData["Name"] = data.Name;
            return RedirectToAction("Thanks");
        }

        public ActionResult Thanks()
        {
            var model = new ThanksViewModel
            {
                Name = (string)TempData["Name"]
            };
            return View(model);
        }
    }
}