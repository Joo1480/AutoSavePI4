using Microsoft.AspNetCore.Mvc;

namespace AutoSavePI4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
