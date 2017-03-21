using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescGym
{
    public partial class frmLogin : Form
    {
        private static frmLogin nWindows;
        /// <summary>
        /// FUNCION QUE ME PERMITE ONTENER LA INTANCIA DE LA VENTAN
        /// </summary>
        public static frmLogin getItancia {
            get {
                if (nWindows == null || nWindows.IsDisposed)
                    nWindows = new frmLogin();
                return nWindows;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }
    }
}
