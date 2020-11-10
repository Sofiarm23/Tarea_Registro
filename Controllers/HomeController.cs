using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tarea_Registro.Models;

namespace Tarea_Registro.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Registro(Registro registro)
        {
            if (ModelState.IsValid)
            {
                // TODO: Hacer algo con los parametros del objeto Registro
                return RedirectToAction("RegistroConfirmacion");
            }
            return View(registro);
            
        }

        public IActionResult RegistroConfirmacion()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
