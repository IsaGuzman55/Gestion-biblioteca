using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{

    public class PrestamoLibroController : Controller{
        public IActionResult Index(){
            return View();
        }
        
        public IActionResult Crear(){
            return View();
        }
        
        public IActionResult Editar(){
            return View();
        }

        public IActionResult Eliminar(){
            return View();
        }

        public IActionResult Detalles(){
            return View();
        }
    }
};