using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{

    public class DashboardController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}