using Microsoft.AspNetCore.Mvc;

namespace CameraShop.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
