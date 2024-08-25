using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class GiangController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}