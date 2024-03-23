using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{

    public class UsuariosController: Controller{

        public IActionResult Index(){
            return View();
        }

        public IActionResult Crear(){
            return View();
        }


    }
}