using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisVentasWEB.Models;
using System.Data;

namespace SisVentasWEB.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Articulo()
        {
            SisVentasEntitiesArticulo cdb2 = new SisVentasEntitiesArticulo();

            return View(from ass in cdb2.Articulo.ToList() select ass);
        }

       
    }
}