using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAES.Model.SistemaIntegrado
{
    [Table("DisolucionCooperativaAnterior")]
    public class DisolucionCooperativaAnterior
    {
        public DisolucionCooperativaAnterior()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int DisolucionCooperativaAnteriorId { get; set; }

        [Display(Name = "Organización")]
        public int? OrganizacionId { get; set; }
        public virtual Organizacion Organizacion { get; set; }

        [Display(Name ="Tipo de Norma")]
        public int? TipoNormaId { get; set; }
        public virtual TipoNorma TipoNorma { get; set; }

        /*[Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }*/

        /*[Display(Name = "Número oficio")]
        public string NumeroOficio { get; set; }*/

        /*[Display(Name = "Fecha de asamblea")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaAsamblea { get; set; }*/

        [Display(Name = "Fecha publicación diario oficial")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaPublicacionDiarioOficial { get; set; }

        [Display(Name ="Autorizada por")]
        public string Autorizacion { get; set; }

        [Display(Name ="Fecha de la Junta general de Socios")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaJuntaSocios { get; set; }

        [Display(Name ="Comision Liquidadora")]
        public bool ComisionLiquidadora { get; set; }
    }
}
