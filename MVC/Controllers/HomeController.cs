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

        public ActionResult Contact()
        {
            return View(new ContactUsViewModel());
        }

        [HttpPost]
        public ActionResult Contact(ContactUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["Name"] = model.Name;
                return RedirectToAction("Thanks");
            }
            return View(model);
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