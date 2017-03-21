using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DescGym.Modelo
{
    [Table(name:"Pagos")]
    public class Pago
    {
        [Key]
        public int pkPago { get; set; }
        public DateTime dFechaPago { get; set; }
        [Required(ErrorMessage ="Debe indicar el empleado")]
        public int fkUsuarioEmpleado { get; set; }
        public Double dTotal { get; set; }
        public Double dDescuento { get; set; }
        public string sComentario { get; set; }

        public Boolean bStatus { get; set; }

        public virtual Membrecia membrecia { get; set; }

        public Pago() {
            this.dFechaPago = System.DateTime.Now;
            this.dTotal = 0;
            this.dDescuento = 0;
            this.sComentario = "";
            this.bStatus = true;
        }

    }
}
