using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Reportes
    {
        public static DataTable PreciosPorCategoria(int idCat)
        {
            return ReporteBD.PreciosPorCategoria(idCat);
        }

        public static DataTable InsumosUtilizados(DateTime fecha)
        {
            return ReporteBD.InsumosUtilizados(fecha);
        }

        public static DataTable VentasPorDia(DateTime fecha)
        {
            return ReporteBD.VentasPorDia(fecha);
        }

        public static DataTable VentasPorMozo(DateTime fecha, long cuilMozo)
        {
            return ReporteBD.VentasPorMozo(fecha, cuilMozo);
        }
    }
}
