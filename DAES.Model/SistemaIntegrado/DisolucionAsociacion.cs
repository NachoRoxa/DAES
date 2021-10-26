﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAES.Model.SistemaIntegrado
{
    [Table("DisolucionAsociacion")]
    public class DisolucionAsociacion
    {
        public DisolucionAsociacion()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int DisolucionAsociacionId { get; set; }

        [Display(Name ="Numero de Oficio")]
        public int NumeroOficio { get; set; }

        [Display(Name ="Fecha de Oficio")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaOficio { get; set; }

        [Display(Name ="Fecha de Asamble Extraordinario de Socios")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaAsambleaSocios { get; set; }

        [Display(Name ="Fecha Escritura Publica")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEscrituraPublica { get; set; }
        
        [Display(Name = "Fecha de Publicación en el Diario Oficial")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaPublicacionDiarioOficial { get; set; }
        
        [Display(Name = "Nombre de la Notaría")]
        public string NombreNotaria { get; set; }

        [Display(Name = "Datos del Notario")]
        public string DatosNotario { get; set; }
    }
}
