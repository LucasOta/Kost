using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CapaDatos;

namespace CapaNegocio
{
    static class Validaciones
    {
        public static Boolean Nombre(String n)
        {
            string pattern = "([A-Z][a-z,ñ,á,é,í,ó,ú]{1,11}){1,4}";
            string input = n;

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Apellido(String n)
        {
            string pattern = "([A-Z][a-z,ñ,á,é,í,ó,ú]{1,11}){1,4}";
            string input = n;

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Cuil(long n)
        {
            string pattern = "^(20|23|24|27|30|33|34)\\d{8}(0|1|2|3|4|5|6|7|8|9)$";
            string input = Convert.ToString(n);

            if (Regex.IsMatch(input, pattern))
            {

                String cuit = Convert.ToString(n);
                char[] cuitArray = cuit.ToCharArray();
                int[] serie = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                long aux = 0;

                for (int i = 0; i < serie.Length; i++)
                {
                    aux += Convert.ToInt64(Char.GetNumericValue(cuitArray[i])) * serie[i];
                }

                aux = 11 - (aux % 11);

                if (aux == 11)
                {
                    aux = 0;
                }

                if (aux == Convert.ToInt64(Char.GetNumericValue(cuitArray[10])))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Direccion(String n)
        {
            string pattern = "(([A-Za-z][a-z,á,ñ,é,í,ó,ú]{1,20}([ ][A-Za-z][a-z,á,ñ,é,í,ó,ú]{1,20}){0,5})[ ]\\d{1,5})";
            string input = n;

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Telefono(String n)
        {
            string pattern = "\\d{4} \\d{6}";
            string input = n;

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Mail(String n)
        {
            string pattern = "^([0-9a-zA-Z]+[-._+&])*[0-9a-zA-Z]+@([-0-9a-zA-Z]+[.])+[a-zA-Z]{2,6}$";
            string input = n;

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Nacimiento(DateTime n)
        {
            if (n < DateTime.Today && n.Year > (DateTime.Today.Year - 90))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Usuario(String n)
        {
            if (CapaDatos.UsuarioBD.existe(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Mozo(long n)
        {
            if (CapaDatos.MozoBD.existe(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Categoria(string n)
        {
            if (CapaDatos.CategoriaBD.existe(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Comanda(int n)
        {
            if (CapaDatos.ComandaBD.existe(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean ComandaDeMesaActiva(int nroMesa)
        {
            return CapaDatos.ComandaBD.comandaDeMesaActiva(nroMesa);
        }
    }
}