using Microsoft.AspNetCore.Mvc;

namespace PortFolio.web.Controllers
{
    public class AdminController : Controller
    {
                  
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
