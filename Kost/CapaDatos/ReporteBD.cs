using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ReporteBD
    {
        public static DataTable PreciosPorCategoria(int idCat)
        {
            DataTable preciosPorCategorias = new DataTable("preciosPorCategorias");

            string sql = "SELECT nombre, precioVenta " +
                         "FROM Productos " +
                         "WHERE baja = 0 and idCategoria = @idCat;";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

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

        public static DataTable InsumosUtilizados(DateTime fecha)
        {
            DataTable insumosUtilizados = new DataTable("insumosUtilizados");

            string sql = "SELECT P.codProd, P.nombre, SUM(S.contenido) AS cantidad " +
                         "FROM ProdSimples S INNER JOIN Composicion Comp " +
                                    "ON S.codProdSimple = Comp.codProdSimple INNER JOIN ProdCompuestos PC " +
                                    "ON Comp.codProdCompuesto = PC.codProdCompuesto INNER JOIN Productos P " +
                                    "ON P.codProd = S.codProdSimple INNER JOIN  Detalle D " +
                                    "ON D.codProd = PC.codProdCompuesto INNER JOIN Comandas C " +
                                    "ON C.nroComanda = D.nroComanda " +
                         "WHERE  convert(varchar, C.fecha, 105) = @fecha " +
                         "GROUP BY S.codProdSimple, P.codProd, P.nombre;";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("fecha", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = Convert.ToString( fecha.Day )+ "-" + Convert.ToString(fecha.Month) + "-" + Convert.ToString(fecha.Year);

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

        public static DataTable VentasPorDia(DateTime fecha)
        {
            DataTable ventasPorDia = new DataTable("ventasPorDia");

            string sql = "SELECT CONCAT(P.nombre,' ',P.apellido) AS mozo, C.nroComanda, C.precioFinal " +
                "FROM(Personas P INNER JOIN Mozos M ON P.cuil = M.cuilMozo) INNER JOIN Comandas " +
                "C ON C.cuilMozo = M.cuilMozo WHERE convert(varchar, C.fecha, 105) = @fecha AND C.activa = 0;";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("fecha", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = Convert.ToString(fecha.Day) + "-" + Convert.ToString(fecha.Month) + "-" + Convert.ToString(fecha.Year);

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(ventasPorDia); //Llenamos el DataTable
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                ventasPorDia = null;
            }
            return ventasPorDia;
        }

        public static DataTable VentasPorMozo(DateTime fecha, long cuilMozo)
        {
            DataTable ventasPorDia = new DataTable("ventasPorDia");

            string sql = "SELECT C.nroComanda, C.total, C.fecha " +
                        "FROM(Personas P INNER JOIN Mozos M ON P.cuil = M.cuilMozo) INNER JOIN Comandas C " +
                                                            "ON C.cuilMozo = M.cuilMozo " +
                         "WHERE convert(varchar, C.fecha, 105) = @fecha AND M.cuilMozo = @cuilMozo AND C.activa = 0 AND C.baja=0;";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("fecha", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = Convert.ToString(fecha.Day) + "-" + Convert.ToString(fecha.Month) + "-" + Convert.ToString(fecha.Year);

                Cx.sqlCmd.Parameters.Add("cuilMozo", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[1].Value = cuilMozo;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(ventasPorDia); //Llenamos el DataTable
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                ventasPorDia = null;
            }
            return ventasPorDia;
        }
    }
}
