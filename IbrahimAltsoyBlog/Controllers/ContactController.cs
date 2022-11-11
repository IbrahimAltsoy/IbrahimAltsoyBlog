using Microsoft.AspNetCore.Mvc;

namespace IbrahimAltsoyBlog.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string email, string messaje)
        {
            ViewBag.email = "Email: " + email;
            ViewBag.messaje = "Mesajınız: " + messaje;
            ViewBag.sonuc = "Email adresiniz ile beraber mesajınız iletildi.";
            return View();
        }
    }
}
