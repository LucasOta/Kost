using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProductoCompuestoBD
    {
        public static Boolean existe(int codProdComp)
        {
            string sql = "SELECT baja FROM ProdCompuestos WHERE codProdCompuesto =  @codProdCompuesto";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProdCompuesto", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProdComp;

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

        public static Boolean existeComposicion(int codProdComp, int codProdSimpl, int cantidad)
        {
            string sql = "SELECT baja FROM Composicion WHERE codProdCompuesto =  @codProdSimpl AND codProdSimple = @codProdSimpl AND cantidad = @cantidad";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProdCompuesto", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProdComp;

                cx.sqlCmd.Parameters.Add("@codProdSimpl", SqlDbType.Int);
                cx.sqlCmd.Parameters[1].Value = codProdSimpl;

                cx.sqlCmd.Parameters.Add("@cantidad", SqlDbType.Int);
                cx.sqlCmd.Parameters[2].Value = cantidad;

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

        public static bool guardar(int pCod)
        {
            string sql = "INSERT INTO ProdCompuestos (codProdCompuesto, baja) values (@pCod, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("pCod", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = pCod;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[1].Value = 0;

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

        public static bool guardarComposicion(int pCodC, int pCodS, int c)
        {
            string sql = "INSERT INTO Composicion (codProdCompuesto, codProdSimple, cantidad, baja) values (@pCodC, @pCodS, @c @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("pCodC", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = pCodC;

                Cx.sqlCmd.Parameters.Add("pCodS", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pCodS;

                Cx.sqlCmd.Parameters.Add("c", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = c;

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

        //        public static Boolean modificar(int pCod, int pStock, bool pInsumo)
        //        {
        //            string sql = "UPDATE ProdSimples SET pStock=@stock, pInsumo=@insumo WHERE codProd=@codProd and baja=@baja";

        //            try
        //            {
        //                Conexion Cx = new Conexion();

        //                Cx.setComandoTexto();
        //                Cx.setSQL(sql);

        //                Cx.sqlCmd.Parameters.Add("stock", SqlDbType.Float);
        //                Cx.sqlCmd.Parameters[0].Value = pStock;

        //                Cx.sqlCmd.Parameters.Add("insumo", SqlDbType.Int);
        //                Cx.sqlCmd.Parameters[1].Value = pInsumo;

        //                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
        //                Cx.sqlCmd.Parameters[3].Value = 0;

        //                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
        //                Cx.sqlCmd.Parameters[2].Value = 0;

        //                Cx.abrir();
        //                object nro = Cx.sqlCmd.ExecuteNonQuery();
        //                Cx.cerrar();
        //                if (Convert.ToInt32(nro) > 0)
        //                {
        //                    return true;
        //                }
        //                return false;
        //            }
        //#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
        //            catch (Exception e)
        //#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
        //            {
        //                return false;
        //            }
        //        }

        public static Boolean eliminar(int cod)
        {
            string sql = "UPDATE ProdCompuestos SET baja=@baja WHERE codProdCompuesto=@codProdCompuesto;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdCompuesto", SqlDbType.Int);
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

        public static Boolean eliminarComposicion(int pCodC, int pCodS, int c)
        {
            string sql = "UPDATE Composicion SET baja=@baja WHERE codProdCompuesto=@codProdCompuesto AND  codProdSimple = @codProdSimpl AND cantidad = @cantidad;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProdCompuesto", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pCodC;

                Cx.sqlCmd.Parameters.Add("codProdSimple", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = pCodS;

                Cx.sqlCmd.Parameters.Add("cantidad", SqlDbType.Int);
                Cx.sqlCmd.Parameters[3].Value = c;

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

        public static DataTable TraerUnProdCompuesto(int cod)
        {
            DataTable productoCompuesto = new DataTable("ProductoCompuesto");

            string sql = "SELECT S.nombre, C,cantidad FROM ProdSimples S INNER JOIN Composicion WHERE codProdCompuesto = @codProdCompuesto and baja=0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

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
