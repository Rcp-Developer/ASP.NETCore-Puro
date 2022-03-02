using Microsoft.AspNetCore.Mvc;

namespace meu_aula1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
