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
        //Envío de mensajes a la interfaz.
        public static void mError(UserControl actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
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


        //Manejo de excepciones de la interfaz.
        public static Boolean RowSeleccionado(int c, string obj, string msj, UserControl uc)
        {
            if (c == 1)
            {
                return true;
            }
            else if (c == 0)
            {
                Funciones.mAdvertencia(uc, "Debe seleccionar " + obj + " para poder " + msj);
                return false;
            }
            else
            {
                Funciones.mAdvertencia(uc, "Debe seleccionar sólo " + obj + ".");
                return false;
            }
        }

        //Textboxs
        public static Boolean soloLetras(char e)
        {
            Boolean result = false;
            if (Char.IsLetter(e))
            {
                result = false;
            }
            else if (Char.IsControl(e))
            {
                result = false;
            }
            else if (Char.IsSeparator(e))
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }
        public static Boolean sinEspacios(char e)
        {


            Boolean result = false;
            if (Char.IsSeparator(e))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
