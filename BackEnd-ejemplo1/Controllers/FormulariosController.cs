using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Controllers
{
    public class FormulariosController : Controller
    {
        // GET: Formularios
        public ActionResult Index()
        {
            trabajador obj = new trabajador();

            return View(obj);
        }
        public ActionResult Index2()
        {
            trabajador obj =  new trabajador();

            return View(obj);
        }
    }
}