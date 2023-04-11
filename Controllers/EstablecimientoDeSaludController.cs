using Microsoft.AspNetCore.Mvc;
using BBT_Plataforma_Establecimientos_De_Salud.Models.DB;

namespace BBT_Plataforma_Establecimientos_De_Salud.Controllers
{
    public class EstablecimientoDeSaludController : Controller
    {
        public IActionResult Buscar(string criterio)
        {
            EstablecimientoDeSalud objEst = new EstablecimientoDeSalud();
            var listEst = objEst.Buscar(criterio);
            return View(listEst);
        }
    }
}
