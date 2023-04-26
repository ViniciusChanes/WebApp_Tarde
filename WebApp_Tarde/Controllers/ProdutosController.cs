using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index() // equivalente  a lista
        {
            return View( db.Produtos.ToList() );
        }
        public readonly Contexto db;

        public ProdutosController(Contexto opt)
        {
            db = opt;
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
