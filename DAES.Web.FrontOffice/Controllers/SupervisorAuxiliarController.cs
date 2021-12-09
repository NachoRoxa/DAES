using DAES.Web.FrontOffice.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAES.Web.FrontOffice.Controllers
{
    [Audit]
    public class SupervisorAuxiliarController : Controller
    {
        public class Search
        {
            public Search()
            {
                Supervisores = new List<SupervisorAuxiliar>();
            }
        }

        // GET: SupervisoresAuxiliares
        public ActionResult Index()
        {
            return View();
        }
    }
}