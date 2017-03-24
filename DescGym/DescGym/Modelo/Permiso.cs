using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DescGym.Modelo
{
    [Table(name:"Permisos")]
    public class Permiso
    {
        [Key]
        public int PermisoId { get; set; }
        [Required(ErrorMessage = "Falta el Nombre")]
        public String sNombre { get; set; }        
        public String sDescripcion { get; set; }

        public virtual ICollection<PermisoNegado> PermisosNegados { get; set; }
    }
}
