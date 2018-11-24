using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DetalleBD
    {
        public static String Guardar(int nroComanda, int codProducto, string descrip, int cantidad, float precioUni)
        {
            string sql = "INSERT INTO Detalle (nroComanda, codProd, descripProd, cantidad, precioUni, baja) values (@nroComanda, @codProd, @descripProd, @cantidad, @precioUni, 0)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nroComanda", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = nroComanda;

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = codProducto;

                Cx.sqlCmd.Parameters.Add("descripProd", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[2].Value = descrip;

                Cx.sqlCmd.Parameters.Add("cantidad", SqlDbType.Int);
                Cx.sqlCmd.Parameters[3].Value = cantidad;

                Cx.sqlCmd.Parameters.Add("precioUni", SqlDbType.Float);
                Cx.sqlCmd.Parameters[4].Value = precioUni;

                Cx.Abrir();
                object nro = Cx.sqlCmd.ExecuteNonQuery();
                Cx.Cerrar();
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

        public static Boolean Modificar(int nroDetalle, int codProd, int cantidad, float precioUni, string descrip)
        {
            string sql = "UPDATE Detalle SET codProd = @codProd, descripProd = @descrip, cantidad = @cantidad, precioUni = @precio, baja = 0 WHERE nroDetalle = @nroDetalle;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("codProd", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = codProd;

                Cx.sqlCmd.Parameters.Add("descrip", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[1].Value = descrip;

                Cx.sqlCmd.Parameters.Add("cantidad", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = cantidad;

                Cx.sqlCmd.Parameters.Add("precio", SqlDbType.Float);
                Cx.sqlCmd.Parameters[3].Value = precioUni;

                Cx.sqlCmd.Parameters.Add("nroDetalle", SqlDbType.Int);
                Cx.sqlCmd.Parameters[4].Value = nroDetalle;

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

        public static Boolean Eliminar(int nroDetalle)
        {
            string sql = "UPDATE Detalle SET baja = 1 WHERE nroDetalle = @nroDeta;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nroDeta", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = nroDetalle;

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

        public static DataTable TraerTodosDetalles(int nroComanda)
        {
            DataTable detalles = new DataTable("detalles");

            string sql = "SELECT nroDetalle, codProd, descripProd, cantidad, precioUni FROM Detalle WHERE nroComanda = @nroComanda AND baja = 0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nroComanda", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = nroComanda;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(detalles);

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                detalles = null;
            }
            return detalles;
        }

        public static DataTable TraerUnDetalle(int nroDetalle)
        {
            DataTable detalle = new DataTable("Detalle");

            string sql = "SELECT * FROM Detalle WHERE nroDetalle = @nroDetalle";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nroDetalle", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = nroDetalle;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(detalle);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                detalle = null;
            }

            return detalle;
        }
    }
}
