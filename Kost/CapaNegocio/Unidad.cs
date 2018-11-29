using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class Unidad
    {
        public static DataTable ListarTodos()
        {
            return CapaDatos.UnidadBD.TraerTodos();
        }
    }
}
