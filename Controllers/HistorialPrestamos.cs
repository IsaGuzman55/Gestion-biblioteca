using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{

    public class HistorialPrestamosController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}