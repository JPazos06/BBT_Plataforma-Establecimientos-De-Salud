using Microsoft.AspNetCore.Mvc;
using BBT_Plataforma_Establecimientos_De_Salud.Models.DB;

namespace BBT_Plataforma_Establecimientos_De_Salud.Controllers
{
    public class EstablecimientoDeSaludController : Controller
    {
        EstablecimientoDeSalud Est = new EstablecimientoDeSalud();
        public IActionResult Buscar(string criterio)
        {
            EstablecimientoDeSalud objEst = new EstablecimientoDeSalud();
            var listEst = objEst.Buscar(criterio);
            return View(listEst);
        }
        public IActionResult Detalle(int EstId)
        {
            EstablecimientoDeSalud objEst = new EstablecimientoDeSalud();
            var IdEst = objEst.BuscarId(EstId);
            return View(IdEst);
        }
    }
}
