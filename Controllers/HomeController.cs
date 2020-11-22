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

          /*  var usuario = new Home();

            usuario.Id = Guid.NewGuid().ToString();
            usuario.Edad = 50;
            usuario.Nombre = "Fernando";
            usuario.Password = "Fernando";
            usuario.Correo = "fernando1999jw@gmail.com";*/


            var catalago = new CatalogoReportes();


            catalago.Nombre = "Mantenimiento 1";
            catalago.Nombre2 = "Mantenimiento 2";
            catalago.Nombre3 = "Mantenimiento 3";
            catalago.Nombre4 = "Mantenimiento 4";
            catalago.Nombre1 = "Mantenimiento 5";




            return View(catalago);
        }


        public IActionResult CatalogoReportes()
        {

            

            return View();
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
          
            reporte.Id = Guid.NewGuid().ToString();
          

            return View(reporte);
        }
        public IActionResult Solicitudes()
        {
            var solicitud = new Home();
           
            solicitud.Id = Guid.NewGuid().ToString();
       

            return View(solicitud);
           
        }
        public IActionResult Asignaciones()
        {
            var asignacion = new Home();
           
            asignacion.Id = Guid.NewGuid().ToString();
          
            return View(asignacion);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
