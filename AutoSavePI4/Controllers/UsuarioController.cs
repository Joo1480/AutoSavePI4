using Microsoft.AspNetCore.Mvc;
using AutoSavePI4.Entidades;

namespace AutoSavePI4.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Contexto contexto;

        public UsuarioController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        public IActionResult CadastroCaminhoneiro()
        {
            return View();
        }
        public IActionResult CadastroVeiculo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(Usuario collection)
        {
            try
            {
                if (collection.Codigo == 0)
                {
                    Usuario novo = new Usuario();
                    novo = collection;
                    contexto.USUARIO.Add(novo);
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        contexto.USUARIO.Update(collection);
                        contexto.SaveChanges();
                        return RedirectToAction(nameof(CadastroVeiculo));
                    }
                    else
                    {
                        return View(collection);
                    }
                }

            }
            catch
            {
                return View();
            }
        }
    }
}
