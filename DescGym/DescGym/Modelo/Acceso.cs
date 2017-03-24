using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DescGym.Modelo
{
    [Table(name:"Accesos")]
    public class Acceso
    {
        [Key]
        public int AccesoId { get; set; }
        public DateTime dFechaAcceso { get; set; }
        public virtual Usuario usuario { get; set; }

        public Boolean bStatus { get; set;   }

        public Acceso() {
            this.dFechaAcceso = System.DateTime.Now;
            this.bStatus = true;
        }
    }
}
