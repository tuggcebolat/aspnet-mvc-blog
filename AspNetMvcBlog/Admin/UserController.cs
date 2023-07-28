using Microsoft.AspNetCore.Mvc;

namespace ASPNetMvcBlog.Admin
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
