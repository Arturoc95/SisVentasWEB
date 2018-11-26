using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.SqlServer;
using System.Data;
using System.EnterpriseServices;
using SisVentasWEB.Models;

namespace SisVentasWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SisVentasEntities cdb = new SisVentasEntities();
            return View(from emp in cdb.Categoria.ToList()
                        select emp);
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}