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
        public static DataTable preciosPorCategoria(int idCat)
        {
            DataTable preciosPorCategorias = new DataTable("preciosPorCategorias");

            string sql = "SELECT nombre, precioVenta FROM Productos WHERE baja = 0 and idCategoria = @idCat";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("idCat", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = idCat;

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
            DataTable insumosUtilizados = new DataTable("insumosUtilizados");

            string sql = "SELECT P.codProd, P.nombre, S.contenido FROM((((ProdSimples S INNER JOIN Composicion Comp ON S.codProdSimple = Comp.codProdSimple) INNER JOIN ProdCompuestos PC ON Comp.codProdCompuesto = PC.codProdCompuesto INNER JOIN Productos P ON P.codProd = S.codProdSimple) INNER JOIN  Detalle D ON D.codProd = PC.codProdCompuesto) INNER JOIN Comandas C on C.nroComanda = D.nroComanda WHERE C.fecha = '2018-10-27 16:07:59.073' and S.codProdSimple = P.codProd;";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("fecha", SqlDbType.DateTime);
                Cx.sqlCmd.Parameters[0].Value = fecha;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(insumosUtilizados); //Llenamos el DataTable
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                insumosUtilizados = null;
            }
            return insumosUtilizados;
        }
    }
}
