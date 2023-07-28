using Microsoft.AspNetCore.Mvc;

namespace ASPNetMvcBlog.Admin
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
