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
        public static Boolean ExisteCodigo(int codProd)
        {
            string sql = "SELECT baja FROM Productos WHERE codProd =  @codProd";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProd", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProd;

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

        public static Boolean ExisteNombre(string nombre)
        {
            string sql = "SELECT baja FROM Productos WHERE nombre =  @nombre";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cx.sqlCmd.Parameters[0].Value = nombre;

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

        public static int Guardar(string pnombre, string pdescripcion, int pidCategoria, float pprecio, bool compuesto, int pStock, bool pInsumo, int unidad, double contenido)
        {
            string sql = "INSERT INTO Productos (nombre, precioVenta, idCategoria, descripProd, compuesto, baja) " +
                         "VALUES (@nombre, @precioVenta, @idCategoria, @descripProd, @compuesto, @baja); " +
                         "SELECT CAST(scope_identity() AS int);";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

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

                Cx.Abrir();

                Cx.SetTransaccion();
                
                Object nro = Cx.sqlCmd.ExecuteScalar();
                int id_transaccion = Convert.ToInt32(nro);

                if (id_transaccion > 0)
                {
                    bool insertok;
                    if (compuesto)
                    {
                        insertok = ProductoCompuestoBD.Guardar(id_transaccion, Cx);
                    }
                    else
                    {
                        insertok = ProdSimpleBD.Guardar(id_transaccion, pStock, pInsumo, unidad, contenido, Cx);
                    }

                    if (insertok == false)
                    {
                        Cx.TransaccionRollback();
                        Cx.Cerrar();
                        return -1;
                    }
                    else if (id_transaccion < 0)
                    {
                        // si salio mal y id_transaccion es -1 rollback
                        Cx.TransaccionRollback();
                        Cx.Cerrar();
                        return id_transaccion;
                    }
                    else
                    {
                        Cx.ComitTransaccion();
                        Cx.Cerrar();
                        return id_transaccion;
                    }
                }
                else
                {
                    return id_transaccion;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static Boolean ProductoActivo(int cod)
        {
            string sql = "SELECT codProd FROM Productos WHERE codProd =  @cod AND baja = 0";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@cod", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = cod;

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

        public static Boolean Modificar(int codProd, string pnombre, string pdescripcion, int pidCategoria, float pprecio, bool compuesto)
        {
            string sql = "UPDATE Productos SET nombre=@nombre, precioVenta=@precioVenta, idCategoria=@idCategoria, descripProd=@descripProd, compuesto=@compuesto, baja=0 WHERE codProd=@codProd;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

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
                Cx.sqlCmd.Parameters[6].Value = codProd;

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

        public static int Eliminar(int cod, bool compuesto)
        {
            string sql = "UPDATE Productos SET baja=1 WHERE codProd=@codProd;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = cod;

                Cx.Abrir();
                Cx.SetTransaccion();

                Object nro = Cx.sqlCmd.ExecuteScalar();
                int id_transaccion = Convert.ToInt32(nro);

                if (id_transaccion > 0)
                {
                    bool deleteok;
                    if (compuesto)
                    {
                        deleteok = ProductoCompuestoBD.Eliminar(id_transaccion, Cx);
                    }
                    else
                    {
                        deleteok = ProdSimpleBD.Eliminar(id_transaccion, Cx);
                    }

                    if (deleteok == false)
                    {
                        Cx.TransaccionRollback();
                        Cx.Cerrar();
                        return -1;
                    }
                    else if (id_transaccion < 0)
                    {
                        // si salio mal y id_transaccion es -1 rollback
                        Cx.TransaccionRollback();
                        Cx.Cerrar();
                        return id_transaccion;
                    }
                    else
                    {
                        Cx.ComitTransaccion();
                        Cx.Cerrar();
                        return id_transaccion;
                    }
                    //object nro = Cx.sqlCmd.ExecuteNonQuery();
                    //Cx.Cerrar();
                }
                else
                {
                    return id_transaccion;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static DataTable TraerProductos()
        {
            DataTable ds = new DataTable("dataGridProductos");

            string sql = "SELECT codProd, P.nombre, descripProd, C.nombre as categoria, precioVenta, compuesto " +
                        "FROM Productos P INNER JOIN Categorias C ON P.idCategoria=C.idCategoria WHERE P.baja=0 AND C.baja=0";

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

        public static DataTable TraerUnProducto(int cod)
        {
            DataTable producto = new DataTable("Productos");

            string sql = "SELECT codProd, nombre, descripProd, idCategoria, precioVenta, compuesto FROM Productos WHERE codProd = @codprod and baja=0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

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

            string sql = "SELECT codProd, nombre FROM ProdSimples PS RIGHT JOIN Productos P ON +" +
                "PS.codProdSimple = P.codProd WHERE P.baja = 0 AND(PS.insumo = 0 OR P.compuesto = 1); ";

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

        public static DataTable PrecioVenta(int codProd)
        {
            DataTable ds = new DataTable("Precio");

            string sql = "SELECT precioVenta FROM Productos WHERE codProd = @codprod";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codprod", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = codProd;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
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

