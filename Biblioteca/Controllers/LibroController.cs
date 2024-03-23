using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{

    public class LibroController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult Crear(){
            return View();
        }
    }
}