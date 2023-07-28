using Microsoft.AspNetCore.Mvc;

namespace ASPNetMvcBlog.Admin
{
    public class AyarlarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
