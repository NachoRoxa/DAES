using DAES.Infrastructure.SistemaIntegrado;
using DAES.Model.SistemaIntegrado;
using DAES.Web.FrontOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAES.Web.FrontOffice.Controllers
{
    public class RegistroSupervisorController : Controller
    {
        private SistemaIntegradoContext db = new SistemaIntegradoContext();
        public ActionResult Start()
        {
            //TODO Aplicar Clave unica en modo produccion
            Global.CurrentClaveUnica.ClaveUnicaRequestAutorization.method = "Create";

            /*Global.CurrentClaveUnica.ClaveUnicaUser.name = new Name
            {
                nombres = new System.Collections.Generic.List<string> { "IGNACIO", "ALFREDO" },
                apellidos = new System.Collections.Generic.List<string> { "ROCHA", "PAVEZ" }
            };
            Global.CurrentClaveUnica.ClaveUnicaUser = new ClaveUnicaUser();

            Global.CurrentClaveUnica.ClaveUnicaUser.RolUnico = new RolUnico
            {
                numero = 17957898,
                DV = "0",
                tipo = "RUN"
            };*/
            return RedirectToAction(Global.CurrentClaveUnica.ClaveUnicaRequestAutorization.method, Global.CurrentClaveUnica.ClaveUnicaRequestAutorization.controller);
            /*return Redirect(Global.CurrentClaveUnica.ClaveUnicaRequestAutorization.uri);*/
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SupervisorAuxiliar SuperAux)
        {
            if(ModelState.IsValid)
            {
                db.SupervisorAuxiliars.Add(SuperAux);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoPersonaJuridicaId = new SelectList(db.TipoPersonaJuridicas.OrderBy(q => q.NombrePersonaJuridica).ToList(), "TipoPersonaJuridicaId", "NombrePersonaJuridica");

            return View(SuperAux);
        }

        public ActionResult RepresentanteAdd(int SuperId)
        {
            var model = db.SupervisorAuxiliars.Find(SuperId);
            
            var repre = new RepresentanteLegal() { SupervisorAuxiliarId = model.SupervisorAuxiliarId };

            db.RepresentantesLegals.Add(repre);
            db.SaveChanges();
            return null;
        }

        // GET: RegistroSupervisor
        public ActionResult Index()
        {
            return View();
        }
    }
}