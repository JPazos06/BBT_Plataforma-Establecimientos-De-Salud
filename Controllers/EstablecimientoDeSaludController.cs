﻿using Microsoft.AspNetCore.Mvc;

namespace BBT_Plataforma_Establecimientos_De_Salud.Controllers
{
    public class EstablecimientoDeSaludController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
