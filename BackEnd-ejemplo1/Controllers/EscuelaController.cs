using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            ViewBag.Nombre = "Eduardo Tomas";
            ViewBag.correo = "eduardo@gmail.com";
            ViewBag.Fecha = new DateTime(2001, 12, 10);
            return View();
        }
        public ActionResult Index2()
        {
            ViewData["Nombre"] = "Danna Marlene";
            ViewData["correo"] = "25005489@alumnos.utleon.mx";
            ViewData["FechaNaci"] = new DateTime(2002, 04, 05);
            return View();
        }

        public ActionResult Agregar(trabajador emp)
        {

            return View(emp);
        }
        public ActionResult Agregar2(trabajador emp)
        {
            var trab = new trabajador()
            {
                Nombre = "Pedro",
                Apellidos = "Lopez",
                FechaNacimiento = new DateTime(2000, 1, 1),
                Sueldo = 250,
                EsFijo = true
            };
            ViewBag.Trabajador = trab;

            return View(emp);
        }
        public List<SelectListItem>ObtenerListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text="Si",
                    Value="1"
                },
                new SelectListItem()
                {
                    Text="No",
                    Value="2"
                },
            };
        }
    }
    
}