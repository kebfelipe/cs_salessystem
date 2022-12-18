using Microsoft.AspNetCore.Mvc;

namespace cs_salessystem.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        public IActionResult User()
        {
            return View();
        }
    }
}
