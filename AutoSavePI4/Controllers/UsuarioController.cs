using Microsoft.AspNetCore.Mvc;

namespace AutoSavePI4.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult CadastroCaminhoneiro()
        {
            return View();
        }
        public IActionResult CadastroVeiculo()
        {
            return View();
        }
    }
}
