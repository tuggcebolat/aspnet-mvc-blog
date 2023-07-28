using Microsoft.AspNetCore.Mvc;

namespace ASPNetMvcBlog.Admin
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
