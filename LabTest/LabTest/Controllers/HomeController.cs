
using Microsoft.AspNetCore.Mvc;

namespace LabTest.Controllers

{

    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        
    }
}
