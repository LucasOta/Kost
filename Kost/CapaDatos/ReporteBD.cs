using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class ReporteBD
    {
        public static DataTable preciosProCategoria(int idCat)
        {
            DataTable preciosPorCategorias = new DataTable("preciosPorCategorias");

            string sql = "SELECT nombre, precioVenta FROM Productos WHERE baja = 0 and idCategoria = @idCat";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(preciosPorCategorias); //Llenamos el DataTable
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                preciosPorCategorias = null;
            }
            return preciosPorCategorias;
        }

        public static DataTable insumosUtilizados(DateTime fecha)
        {
            DataTable preciosPorCategorias = new DataTable("preciosPorCategorias");

            string sql = "SELECT nombre, precioVenta FROM Productos WHERE baja = 0 and idCategoria = @idCat";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(preciosPorCategorias); //Llenamos el DataTable
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                preciosPorCategorias = null;
            }
            return preciosPorCategorias;
        }
    }
}
