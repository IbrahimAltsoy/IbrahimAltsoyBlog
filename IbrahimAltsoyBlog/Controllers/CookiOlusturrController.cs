using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IbrahimAltsoyBlog.Controllers
{
    public class CookiOlusturrController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CookieOlustur(string name, string password)
        {
            if (name == "admin" && password == "123456")
            {
                CookieOptions cookieAyarlari = new() // çerez ayarları için
                {
                    Expires = DateTime.Now.AddMinutes(1), // oluşacak çerezin yaşam süresi 1 dk
                };
                Response.Cookies.Append("kulAdi", name, cookieAyarlari); // kullaniciAdi isminde bir çerez oluştur, içinde sayfadan gönderilen veriyi sakla
                Response.Cookies.Append("password", password, cookieAyarlari);
                Response.Cookies.Append("userguid", Guid.NewGuid().ToString()); // bu kullanıcı için benzersiz bir değer oluşturduk
                return RedirectToAction("CookieOku");
            }
            else
            {
                TempData["mesaj"] = "Giriş Başarısız!";
                TempData["name"] = name;

                TempData["password"] = password;

                return RedirectToAction("Index");

            }
                
        }
        public IActionResult CookieOku()
        {
            if (Request.Cookies["userguid"] is null)
                return RedirectToAction("Index");
            TempData["name"] = Request.Cookies["kulAdi"];
            TempData["kullaniciguid"] = Request.Cookies["userguid"];
            return View();
        }
        public IActionResult CookieSil()
        {
            Response.Cookies.Delete("kulAdi");
            Response.Cookies.Delete("userguid");
            Response.Cookies.Delete("sifre");
            return RedirectToAction("CookieOku");
        }
    }
}
