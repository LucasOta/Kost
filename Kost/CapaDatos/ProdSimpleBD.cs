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
        public static Boolean Existe(int codProdSimpl)
        {
            string sql = "SELECT baja FROM ProdSimples WHERE codProdSimple =  @codProdSimpl";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProdSimpl", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProdSimpl;

                cx.Abrir();
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

        public static bool Guardar(int pCod, int pStock, bool pInsumo, int pUnidad, double pContenido, Conexion Cx)
        {
            string sql = "INSERT INTO ProdSimples (codProdSimple, stock, insumo, unidad, contenido, baja) " + 
                         "VALUES (@pCod, @pStock, @pInsumo, @pUnidad, @pContenido, 0);";

            try
            {
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("pCod", SqlDbType.Int);
                Cx.sqlCmd.Parameters[6].Value = pCod;

                Cx.sqlCmd.Parameters.Add("pStock", SqlDbType.Float);
                Cx.sqlCmd.Parameters[7].Value = (float) pStock;

                Cx.sqlCmd.Parameters.Add("pInsumo", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[8].Value = pInsumo;

                Cx.sqlCmd.Parameters.Add("pUnidad", SqlDbType.Int);
                Cx.sqlCmd.Parameters[9].Value = pUnidad;

                Cx.sqlCmd.Parameters.Add("pContenido", SqlDbType.Float);
                Cx.sqlCmd.Parameters[10].Value = (float) pContenido;

                //Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                //Cx.sqlCmd.Parameters[5].Value = 0;

                
                Cx.sqlCmd.ExecuteNonQuery();

                return true;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return false;
            }
        }

        public static Boolean Modificar(int pCod, int pStock, bool pInsumo, int unidad, double contenido)
        {
            string sql = "UPDATE ProdSimples SET stock=@stock, insumo=@insumo, unidad=@unidad, " +
                "contenido=@contenido WHERE codProdSimple=@codProd and baja=0";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("stock", SqlDbType.Float);
                Cx.sqlCmd.Parameters[0].Value = pStock;

                Cx.sqlCmd.Parameters.Add("insumo", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pInsumo;

                Cx.sqlCmd.Parameters.Add("unidad", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = unidad;

                Cx.sqlCmd.Parameters.Add("contenido", SqlDbType.Float);
                Cx.sqlCmd.Parameters[3].Value = contenido;

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[4].Value = 0;

                Cx.Abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.Cerrar();
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

        public static Boolean Eliminar(int cod)
        {
            string sql = "UPDATE ProdSimples SET baja=1 WHERE codProdSimple=@codProdSimple;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdSimple", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = cod;

                Cx.Abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.Cerrar();
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

            string sql = "SELECT codProdSimple, stock, insumo, unidad, contenido FROM ProdSimples WHERE codProdSimple = @codProdSimple and baja=0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

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
        
        public static DataTable TraerInsumos()
        {
            DataTable ds = new DataTable("insumos");

            string sql = "SELECT codProdSimple, nombre FROM ProdSimples WHERE baja = 0";

            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.Comando());
                sqlDat.Fill(ds);

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                ds = null;
            }
            return ds;
        }

        public static DataTable TraerInsumosdeunProducto(int cod)
        {
            DataTable ds = new DataTable("insumosDeUnProducto");

            string sql = "SELECT S.codProdSimple, P.nombre, C.cantidad FROM (ProdSimples S INNER JOIN Composicion C ON S.codProdSimple = C.codProdSimple) INNER JOIN Productos P ON P.codProd=S.codProdSimple WHERE C.baja = 0 and S.baja = 0 and P.baja = 0 and C.codProdCompuesto";

            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.Comando());
                sqlDat.Fill(ds);

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                ds = null;
            }
            return ds;
        }

        public static DataTable MostrarStock()
        {
            DataTable ds = new DataTable("mostrarstock");

            string sql = "SELECT S.codProdSimple, S.stock, P.nombre, P.descripProd FROM ProdSimples S INNER JOIN Productos P ON S.codProdSimple = P.codProd WHERE S.baja = 0 AND P.baja = 0";

            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.Comando());
                sqlDat.Fill(ds);

            }
            catch (Exception e)
            {
                ds = null;
            }
            return ds;
        }

        public static Boolean ActualizarStock(int pCod, int pStock)
        {
            string sql = "UPDATE ProdSimples SET stock = @stock WHERE codProdSimple = @codProd";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("stock", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = pStock;

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pCod;

                Cx.Abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.Cerrar();
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

        public static DataTable TraerUnidades()
        {
            DataTable ds = new DataTable("Unidades");

            string sql = "SELECT idUnidad, unidad FROM Unidades";

            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.Comando());
                sqlDat.Fill(ds);

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                ds = null;
            }
            return ds;
        }
    }
}
