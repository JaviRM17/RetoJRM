using RetoJRM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetoJRM.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryEmpleado repo;
        public HomeController(IRepositoryEmpleado repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Empleados()
        {
            return View(this.repo.GetEmpleados());
        }
    }
}