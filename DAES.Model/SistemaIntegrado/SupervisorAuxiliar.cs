using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAES.Model.SistemaIntegrado
{
    [Table("SupervisorAuxiliar")]
    class SupervisorAuxiliar
    {
        public SupervisorAuxiliar()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Id")]
        public int SupervisorAuxiliarId { get; set; }

        public string Rut { get; set; }
        public string DomicilioLegal { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        /*Lista Representante Legal*/

        /*Lista escritura constitucion y modificacion*/

        /*Lista Modificaciones*/

        /*Lista extracto*/

        /*Lista personas facultadas de supervision*/
    }
}
