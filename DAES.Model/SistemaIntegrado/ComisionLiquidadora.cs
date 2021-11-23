using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAES.Model.SistemaIntegrado
{
    [Table("ComisionLiquidadora")]
    public class ComisionLiquidadora
    {
        public ComisionLiquidadora()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ComisionLiquidadoraId { get; set; }

        public int? DisolucionId { get; set; }
        public virtual Disolucion Disolucion { get; set; }

        
        public int? DirecitorioId { get; set; }
        public virtual Directorio Directorio { get; set; }

        public string Rut { get; set; }

        public string NombreCompleto { get; set; }
        public int? CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }
        public int? GeneroId { get; set; }
        public virtual Genero Genero { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }

    }
}
