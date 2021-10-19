using System;
using System.Collections.Generic;
using DAES.Infrastructure.SistemaIntegrado;
using DAES.Model.SistemaIntegrado;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAES.Web.FrontOffice.Controllers
{
    public class DisolucionController : Controller
    {
        public class DTOSearch
        {
            public DTOSearch()
            {
                Organizacions = new List<Organizacion>();
            }
            public bool First { get; set; } = true;

            [Display(Name ="Ingrese numero de registro")]
            [Required(ErrorMessage ="Es necesario especificar este dato")]
            public string Filter { get; set; }
            public List<Organizacion> Organizacions { get; set; }
        }

        private SistemaIntegradoContext _db = new SistemaIntegradoContext();

        [HttpPost]
        public ActionResult Search(string Filter)
        {
            IQueryable<Organizacion> query = _db.Organizacion;
            query = query.Where(q => q.EstadoId == (int)Infrastructure.Enum.Estado.Vigente);

            var model = new DTOSearch();
            model.First = false;

            return View(model);
        }


        // GET: Disolucion
        public ActionResult Index()
        {
            return View();
        }
    }
}