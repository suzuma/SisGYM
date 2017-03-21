using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DescGym.Modelo
{
    [Table(name:"Usuarios")]
    public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }
        [Required(ErrorMessage ="Falta Nombre")]
        public String sNombre { get; set; }
        [Required(ErrorMessage = "Falta Apellidos")]
        public String sApellidos { get; set; }
        [Required(ErrorMessage = "Falta Direccion")]
        public String sDireccion { get; set; }
        [Required(ErrorMessage = "Falta Telefono")]
        public String sTelefono { get; set; }
        [Required(ErrorMessage = "Falta Email")]
        public String sEmail { get; set; }
        [Required(ErrorMessage = "Falta Colonia")]
        public String sColonia { get; set; }
        [Required(ErrorMessage = "Falta Ciudad")]
        public String sCiudad { get; set; }
        [Required(ErrorMessage = "Falta Estado")]
        public String sEstado { get; set; }
        [Required(ErrorMessage = "Falta Fotografia")]
        public String sFotografia { get; set; }
        
        public String sIdentificacion { get; set; }

        public Boolean bStatus { get; set; }

        public virtual Membrecia membrecia { get; set; }
        public virtual Rol rol { get; set; }

        public Usuario() {
            bStatus = false;
        }

    }
}
