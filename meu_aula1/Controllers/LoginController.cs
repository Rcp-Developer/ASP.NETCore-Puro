using Microsoft.AspNetCore.Mvc;

namespace meu_aula1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logar(string usuario, string senha)
        {
            if (usuario != null && usuario == "Rodrigo" && senha != null && senha == "123")
            {
                return Content("Logou no sistema");
            }
            else
            {
                ViewBag.msgErro = "Dados inválidos.";
                /*ViewBag.msgErro = "<b>Dados inválidos.</b>";*/
            }

            return View("Index");
        }

        public IActionResult RecuperarSenha()
        {
            return Content("recuperar senha");
        }

        /*public IActionResult RecuperarSenha()
        {
            return View("Index");
        }

        /*public IActionResult RecuperarSenha()
        {
            return null;
        }

        public IActionResult RecuperarSenha()
        {
            return Json();
        }

        public IActionResult RecuperarSenha()
        {
            return File();
        }*/
    }
}
