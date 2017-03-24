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
    public partial class frmFichaRegistroCliente : Form
    {
        public frmFichaRegistroCliente()
        {
            InitializeComponent();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (StringHelper.IsNumeric(e))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!StringHelper.IsFormatoEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese una direccion de email Valida");
            }
            else {
                errorProvider1.SetError(txtEmail, "");
            }
        }
    }
}
