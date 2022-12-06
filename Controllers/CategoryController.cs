using Microsoft.AspNetCore.Mvc;

namespace CameraShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Camera()
        {
            return View();
        }
        public IActionResult Lenses()
        {
            return View();
        }
        public IActionResult Tripod()
        {
            return View();
        }
        public IActionResult Stablizer()
        {
            return View();
        }
        public IActionResult VideoGear()
        {
            return View();
        }
    }
}
