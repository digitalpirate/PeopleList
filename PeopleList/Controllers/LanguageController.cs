using Microsoft.AspNetCore.Mvc;

namespace PeopleIndex.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
