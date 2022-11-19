using IbrahimAltsoyBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace IbrahimAltsoyBlog.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactUs contact)
        {
            return View();
        }
    }
}
