using Microsoft.AspNetCore.Mvc;

namespace CMS.Web.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
