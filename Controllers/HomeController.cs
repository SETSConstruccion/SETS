using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SETS.Models;

namespace SETS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var home = new Home();
            home.AnoFundacion = 2005;
            home.Id = Guid.NewGuid().ToString();
            home.Titulo = "Mantenimiento";
            return View(home);

        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
                  

            return View();
        }
        public IActionResult Reportes()
        {
            var reporte = new Home();
            reporte.AnoFundacion = 2005;
            reporte.Id = Guid.NewGuid().ToString();
            reporte.Titulo = "Reporte";

            return View(reporte);
        }
        public IActionResult Solicitudes()
        {
            var solicitud = new Home();
            solicitud.AnoFundacion = 2005;
            solicitud.Id = Guid.NewGuid().ToString();
            solicitud.Titulo = "Solicitudes";

            return View(solicitud);
           
        }
        public IActionResult Asignaciones()
        {
            var asignacion = new Home();
            asignacion.AnoFundacion = 2005;
            asignacion.Id = Guid.NewGuid().ToString();
            asignacion.Titulo = "asignacion";
            return View(asignacion);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
