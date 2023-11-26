using Microsoft.AspNetCore.Mvc;

namespace AutoSavePI4.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult CadastroEmpresa()
        {
            return View();
        }
    }
}
