using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProductoCompuestoBD
    {
        public static Boolean Existe(int codProdComp)
        {
            string sql = "SELECT baja FROM ProdCompuestos WHERE codProdCompuesto =  @codProdCompuesto";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProdCompuesto", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProdComp;

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

        public static Boolean ExisteComposicion(int codProdComp, int codProdSimpl, int cantidad)
        {
            string sql = "SELECT baja FROM Composicion WHERE codProdCompuesto =  @codProdSimpl AND codProdSimple = @codProdSimpl AND cantidad = @cantidad";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProdCompuesto", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProdComp;

                cx.sqlCmd.Parameters.Add("@codProdSimpl", SqlDbType.Int);
                cx.sqlCmd.Parameters[1].Value = codProdSimpl;

                cx.sqlCmd.Parameters.Add("@cantidad", SqlDbType.Int);
                cx.sqlCmd.Parameters[2].Value = cantidad;

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

        public static bool Guardar(int pCod, Conexion con)
        {
            string sql = "INSERT INTO ProdCompuestos (codProdCompuesto, baja) values (@pCod, @baja)";

            try
            {
                Conexion Cx = con;

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("pCod", SqlDbType.Int);
                Cx.sqlCmd.Parameters[6].Value = pCod;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[7].Value = 0;

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

        public static bool GuardarComposicion(int pCodC, int pCodS, int c)
        {
            string sql = "INSERT INTO Composicion (codProdCompuesto, codProdSimple, cantidad, baja) values (@pCodC, @pCodS, @c @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("pCodC", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = pCodC;

                Cx.sqlCmd.Parameters.Add("pCodS", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pCodS;

                Cx.sqlCmd.Parameters.Add("c", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = c;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[3].Value = 0;

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

        public static Boolean Eliminar(int cod, Conexion con)
        {
            string sql = "UPDATE ProdCompuestos SET baja=1 WHERE codProdCompuesto=@codProdCompuesto;";

            try
            {
                Conexion Cx = con;

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdCompuesto", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = cod;

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

        public static Boolean EliminarComposicion(int pCodC, int pCodS, int c)
        {
            string sql = "UPDATE Composicion SET baja=@baja WHERE codProdCompuesto=@codProdCompuesto AND  codProdSimple = @codProdSimpl AND cantidad = @cantidad;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdCompuesto", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pCodC;

                Cx.sqlCmd.Parameters.Add("codProdSimple", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = pCodS;

                Cx.sqlCmd.Parameters.Add("cantidad", SqlDbType.Int);
                Cx.sqlCmd.Parameters[3].Value = c;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[0].Value = 1;

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

        public static DataTable TraerComposicion(int cod)
        {
            DataTable composicion = new DataTable("Composicion");

            string sql = "SELECT C.codProdSimple, P.nombre, C.cantidad " +
                        "FROM Productos P INNER JOIN Composicion C ON P.codProd = C.codProdSimple " +
                        "WHERE C.codProdCompuesto = @codProdCompuesto and C.baja = 0 and P.baja = 0; ";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdCompuesto", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = cod;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(composicion);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                composicion = null;
            }

            return composicion;
        }

        public static DataTable TraerUnProdCompuesto(int cod)
        {
            DataTable productoCompuesto = new DataTable("ProductoCompuesto");

            string sql = "SELECT nombre, descripcion, idCategoria, precioVenta FROM Productos WHERE codProd = @codProdCompuesto and baja = 0; ";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdCompuesto", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = cod;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(productoCompuesto);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                productoCompuesto = null;
            }

            return productoCompuesto;
        }

    }
}
