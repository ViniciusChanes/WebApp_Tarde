using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class Fornecedores : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
