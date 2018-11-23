using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoBD
    {
        public static Boolean existecodigo(int codProd)
        {
            string sql = "SELECT baja FROM Productos WHERE codProd =  @codProd";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProd", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProd;

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

        public static Boolean existenombre(string nombre)
        {
            string sql = "SELECT baja FROM Productos WHERE nombre =  @nombre";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cx.sqlCmd.Parameters[0].Value = nombre;

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

        public static String guardar(string pnombre, string pdescripcion, int pidCategoria, float pprecio, bool compuesto)
        {
            string sql = "INSERT INTO Productos (nombre, precioVenta, idCategoria, descripProd, compuesto, baja) values (@nombre, @precioVenta, @idCategoria, @descripProd, @compuesto, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("nombre", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = pnombre;

                Cx.sqlCmd.Parameters.Add("precioVenta", SqlDbType.Float);
                Cx.sqlCmd.Parameters[1].Value = pprecio;

                Cx.sqlCmd.Parameters.Add("idCategoria", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = pidCategoria;

                Cx.sqlCmd.Parameters.Add("descripProd", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[3].Value = pdescripcion;

                Cx.sqlCmd.Parameters.Add("compuesto", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[4].Value = compuesto;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[5].Value = 0;

                Cx.abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.cerrar();
                if (Convert.ToInt32(nro) > 0)
                {
                    return "OK";
                }
                return "Error en la conexión a la base de datos.";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static Boolean ProductoActivo(int cod)
        {
            string sql = "SELECT cod FROM Productos WHERE codProd =  @cod AND baja = 0";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@cod", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = cod;

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

        public static Boolean modificar(int codProd, string pnombre, string pdescripcion, int pidCategoria, float pprecio, bool compuesto)
        {
            string sql = "UPDATE Productos SET pnombre=@nombre, pprecio=@precioVenta, pidCategoria=@idCategoria, pdescripcion=@descripProd, compuesto=@compuesto, baja=0 WHERE codProd=@codProd;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("nombre", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = pnombre;

                Cx.sqlCmd.Parameters.Add("precioVenta", SqlDbType.Float);
                Cx.sqlCmd.Parameters[1].Value = pprecio;

                Cx.sqlCmd.Parameters.Add("idCategoria", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = pidCategoria;

                Cx.sqlCmd.Parameters.Add("descripProd", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[3].Value = pdescripcion;

                Cx.sqlCmd.Parameters.Add("compuesto", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[4].Value = compuesto;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[5].Value = 0;

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[6].Value = 0;

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
            string sql = "UPDATE Productos SET baja=@baja WHERE codProd=@codProd;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
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

        public static DataTable DataGridProductos()
        {
            DataTable ds = new DataTable("dataGridProductos");

            string sql = "SELECT codProd, nombre, descripProd, idCategoria, precioVenta, compuesto FROM Productos WHERE baja=0";

            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);
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

        public static DataTable TraerUnProducto(int cod)
        {
            DataTable producto = new DataTable("Productos");

            string sql = "SELECT codProd, nombre, descripProd, idCategoria, precioVenta, compuesto FROM Productos WHERE codProd = @codprod and baja=0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("codprod", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = cod;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(producto);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                producto = null;
            }

            return producto;
        }

        public static DataTable TraerNoInsumos()
        {
            DataTable ds = new DataTable("ProductosNoInsumos");

            string sql = "SELECT P.codProd, P.nombre, P.descripProd, P.idCategoria, P.precioVenta, P.compuesto FROM Productos P INNER JOIN ProdSimples S ON P.baja = 0 WHERE (P.codProd = S.codProdSimple AND S.insumo = 0) OR (P.compuesto = 1);";

            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);
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

