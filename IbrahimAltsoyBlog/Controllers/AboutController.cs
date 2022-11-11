using Microsoft.AspNetCore.Mvc;

namespace IbrahimAltsoyBlog.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
