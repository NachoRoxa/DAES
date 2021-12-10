using DAES.Web.FrontOffice.Helper;
using DAES.Model.SistemaIntegrado;
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
                
            }
        }

        // GET: SupervisoresAuxiliares
        public ActionResult Index()
        {
            var super = new SupervisorAuxiliar();
            return View(super);
        }
    }
}