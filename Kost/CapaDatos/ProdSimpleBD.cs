using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProdSimpleBD
    {
        public static Boolean existe(int codProdSimpl)
        {
            string sql = "SELECT baja FROM ProdSimples WHERE codProdSimple =  @codProdSimpl";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProdSimpl", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProdSimpl;

                cx.abrir();
                SqlDataReader reader = cx.sqlCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return true; //Habría que ver qué mandar si hay un error con la conexión
            }
        }

        public static bool guardar(int pCod, int pStock, bool pInsumo)
        {
            string sql = "INSERT INTO ProdSimples (codProdSimple, stock, insumo, baja) values (@pCod, @pStock, @pInsumo, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("pCod", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = pCod;

                Cx.sqlCmd.Parameters.Add("pStock", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pStock;

                Cx.sqlCmd.Parameters.Add("pInsumo", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[2].Value = pInsumo;
                
                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[3].Value = 0;

                Cx.abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.cerrar();
                if (Convert.ToInt32(nro) > 0)
                {
                    return true;
                }
                return false;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return false;
            }
        }

        public static Boolean modificar(int pCod, int pStock, bool pInsumo)
        {
            string sql = "UPDATE ProdSimples SET pStock=@stock, pInsumo=@insumo WHERE codProd=@codProd and baja=@baja";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("stock", SqlDbType.Float);
                Cx.sqlCmd.Parameters[0].Value = pStock;

                Cx.sqlCmd.Parameters.Add("insumo", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pInsumo;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[3].Value = 0;

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = 0;

                Cx.abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.cerrar();
                if (Convert.ToInt32(nro) > 0)
                {
                    return true;
                }
                return false;
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return false;
            }
        }

        public static Boolean eliminar(int cod)
        {
            string sql = "UPDATE ProdSimples SET baja=@baja WHERE codProdSimple=@codProdSimple;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdSimple", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = cod;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[0].Value = 1;

                Cx.abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.cerrar();
                if (Convert.ToInt32(nro) > 0)
                {
                    return true;
                }
                return false;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return false;
            }
        }

        public static DataTable TraerUnProdSimple(int cod)
        {
            DataTable productoSimple = new DataTable("ProductosSimples");

            string sql = "SELECT codProdSimple, stock, insumo FROM ProdSimples WHERE codProdSimple = @codProdSimple and baja=0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdSimple", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = cod;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(productoSimple);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                productoSimple = null;
            }

            return productoSimple;
        }

        public static DataTable MostrarStock()
        {
            DataTable ds = new DataTable("mostrarstock");

            string sql = "SELECT S.codProdSimple, S.stock, P.nombre, P.descripProd FROM ProdSimples S INNER JOIN Productos P ON S.codProdSimple = P.codProd WHERE S.baja = 0 AND P.baja = 0";

            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.Comando());
                sqlDat.Fill(ds);

            }
            catch (Exception e)
            {
                ds = null;
            }
            return ds;
        }

        public static Boolean actualizarStock(int pCod, int pStock)
        {
            string sql = "UPDATE ProdSimples SET stock = @stock WHERE codProdSimple = @codProd";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("stock", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = pStock;

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pCod;

                Cx.abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.cerrar();
                if (Convert.ToInt32(nro) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
