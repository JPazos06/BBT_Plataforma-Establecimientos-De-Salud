using Microsoft.AspNetCore.Mvc;
using BBT_Plataforma_Establecimientos_De_Salud.Models.DB;

namespace BBT_Plataforma_Establecimientos_De_Salud.Controllers
{
    public class LoginController : Controller
    {
        Usuario usuario = new Usuario();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(Usuario objU)
        {
            Usuario LogUsuario = new Usuario();
            LogUsuario = usuario.Login(objU.Email, objU.Contrasena);
            HttpContext.Session.SetString("UsuarioNombre", LogUsuario.Nombre);
            return RedirectToAction("Index", "Home");
        }
    }
}
