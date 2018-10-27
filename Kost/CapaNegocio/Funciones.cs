using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CapaNegocio
{
    public class Funciones
    {
        public static void mError(UserControl actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Para mostrar mensaje de confirmación.
        public static void mOk(UserControl actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static bool mConsulta(UserControl actual, string mensaje)
        {
            if (MessageBox.Show(actual, mensaje, "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
            // MessageBox.Show(actual, mensaje, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // MessageBox.Show ("Do you want to exit?", "My Application",  MessageBoxButtons.YesNo, MessageBoxIcon.Question)  
        }

        public static void mAdvertencia(UserControl actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
