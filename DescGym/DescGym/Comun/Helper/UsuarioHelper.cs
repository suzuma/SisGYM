using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DescGym.Modelo;
namespace DescGym.Comun.Helper
{
    public class UsuarioHelper
    {
        public Usuario uUsuario { get; set; }
        public String sMensaje { get; set; }
        public Boolean bEsValido { get; set; }

        public UsuarioHelper() {
            uUsuario = new Usuario();
            sMensaje = "Datos incorrectos";
            this.bEsValido = false;
        }
    }
}
