using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DescGym.Comun.Helper
{
    public static class StringHelper
    {

        public static bool IsNumeric(this string str)
        {
            double _val;
            bool valor = double.TryParse(str, out _val);
            return valor;
        }
        public static bool IsLetter(KeyPressEventArgs e)
        {
            return (e.KeyChar >= 65 && e.KeyChar <= 90) ||
                    (e.KeyChar >= 97 && e.KeyChar <= 122) ||
                    e.KeyChar == 8 || e.KeyChar == 'Ñ' || 
                    e.KeyChar == 'ñ' || e.KeyChar == 32;
        }
        public static bool IsDate(this string str)
        {
            DateTime _val;
            bool valor = DateTime.TryParse(str, out _val);
            return valor;
        }
        public static bool IsFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

       

    }
}
