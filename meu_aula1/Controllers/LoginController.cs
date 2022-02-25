using Microsoft.AspNetCore.Mvc;

namespace meu_aula1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logar([FromBody] System.Text.Json.JsonElement dados)
        {
            string senha = dados.GetProperty("Senha").ToString();
            string email = dados.GetProperty("Email").GetString();
            Models.Usuario usuario = new Models.Usuario();
            usuario.Email = email;
            usuario.Senha = senha;
            bool sucesso;
            string mensagem;

            if (usuario.validarLogin())
            {
                sucesso = true;
                mensagem = "Logou";
                /*return Content("Logou no sistema");*/
            }
            else
            {
                sucesso = false;
                mensagem = "Dados incorretos";
                /*
                ViewBag.msgErro = "Dados inválidos.";
                ViewBag.msgErro = "<b>Dados inválidos.</b>";
                */
            }

            //Objeto anônimo, igual ao objeto literal do JavaScript
            /*var retorno = new
            {
                sucesso = sucesso,
                msg = mensagem
            };*/

            JsonResult JsonObj = Json(new
            {
                sucesso = sucesso,
                msg = mensagem
            });

            return JsonObj;

            /*return Json(new
            {
                sucesso = sucesso,
                msg = mensagem
            });*/
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
