using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DescGym.Comun.Helper;

namespace DescGym
{
    public partial class frmMain : Form
    {
        public static UsuarioHelper uUsuario;

        public frmMain()
        {
            InitializeComponent();
            uUsuario = new UsuarioHelper();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void ValidarAutentificacion() {
            if (!uUsuario.bEsValido)
            {
                this.sbpUsuario.Text = "USUARIO: " + uUsuario.uUsuario.sNombre;
            }
            else
            {
                this.sbpUsuario.Text = "USUARIO DESCONOCIDO";
            }
            this.sbpFechaHora.Text = "FECHA: " + System.DateTime.Now.ToShortDateString();
        }
    }
}
