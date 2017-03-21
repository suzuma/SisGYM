using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DescGym.Modelo
{
    [Table(name:"Membrecias")]
   public class Membrecia
    {
        public Membrecia() {
            this.sTipo = TIPO_MEMBRECIA.INVIVIDUAL;
            this.dDescuento = 0;
            this.dFechaRegistro = System.DateTime.Now;
        }

        [Key]
        public int pkMembrecia { get; set; }
        [Required(ErrorMessage ="Falta definir el tipo")]
        public TIPO_MEMBRECIA sTipo { get; set; }
        [Required(ErrorMessage = "Falta establecer el precio")]
        public Double dPrecio { get; set; }
        [Required(ErrorMessage = "Falta definir la perioricidad")]
        public FORMA_PAGO iPrerioricidad { get; set; }
        public Double dDescuento { get; set; }
        public DateTime dFechaRegistro { get; set; }
        [Required(ErrorMessage = "Falta definir fecha vencimiento")]
        public DateTime dFechaRenovacion { get; set; }


        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }

    public enum TIPO_MEMBRECIA {
        INVIVIDUAL,
        PAREJA,
        FAMILIAR,
        EMPRESA
    }
    public enum FORMA_PAGO {
        MENSUAL,
        BIMESTRAL,
        TRIMESTRAL,
        SEMESTRAL,
        ANUAL
    }
}
