using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_aula1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FrameExemplo()
        {
            return View();
        }

        public IActionResult SelectAll(string filtro)
        {
            Models.Usuario usuario = new Models.Usuario();
            List<Models.Usuario> usuarios = usuario.pesquisar(filtro);

            return Json(usuarios);
        }
    }
}
