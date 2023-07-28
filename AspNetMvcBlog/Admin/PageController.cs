using Microsoft.AspNetCore.Mvc;

namespace ASPNetMvcBlog.Admin
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
