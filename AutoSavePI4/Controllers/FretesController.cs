using Microsoft.AspNetCore.Mvc;

namespace AutoSavePI4.Controllers
{
    public class FretesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarFretes()
        {
            return View();
        }
    }
}
