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
        public int ComisionLiquidadoraId { get; set; }

        public int DisolucionId { get; set; }
        public virtual Disolucion Disolucion { get; set; }

        
        public int DirecitorioId { get; set; }
        public virtual Directorio Directorio { get; set; }

    }
}
