using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ComandaBD
    {
        public static Boolean Existe(int nroCom)
        {
            string sql = "SELECT baja FROM Comanda WHERE nroComanda = @nroComanda";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@nroComanda", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = nroCom;

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

        public static String Guardar(DateTime fecha, int nroMesa, long cuilMozo)
        {
            string sql = "INSERT INTO Comandas (fecha, nroMesa, activa, total, descuento, precioFinal, cuilMozo, baja) values (@fecha, @nroMesa, 1, 0, 0, 0, @cuilMozo, 0)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("fecha", SqlDbType.DateTime);
                Cx.sqlCmd.Parameters[0].Value = fecha;

                Cx.sqlCmd.Parameters.Add("nroMesa", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = nroMesa;

                Cx.sqlCmd.Parameters.Add("cuilMozo", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[2].Value = cuilMozo;

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

        public static Boolean Modificar(int nroMesa, long cuilMozo, int nroComanda)
        {
            string sql = "UPDATE Comandas SET nroMesa = @nroMesa, cuilMozo = @cuilMozo WHERE nroComanda = @nroComanda and activa = 1 and baja = 0;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nroMesa", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = nroMesa;

                Cx.sqlCmd.Parameters.Add("cuilMozo", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[1].Value = cuilMozo;

                Cx.sqlCmd.Parameters.Add("nroComanda", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = nroComanda;

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

        public static Boolean Eliminar(int nroComanda)
        {
            string sql = "UPDATE Comandas SET baja = 1, activa = 0 WHERE nroComanda = @nroComanda;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nroComanda", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = nroComanda;

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

        public static DataTable ComandasActivas()
        {
            DataTable comandas = new DataTable("comandasActivas");

            string sql = "SELECT CONCAT(P.nombre,' ', P.apellido)as nya, C.* FROM Personas P INNER JOIN Comandas C ON P.cuil = C.cuilMozo WHERE P.baja = 0 AND C.baja = 0 AND C.activa = 1";

            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.Comando());
                sqlDat.Fill(comandas);

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                comandas = null;
            }
            return comandas;
        }

        public static Boolean CerrarComanda(int nroComanda, float total, float descuento, float precioFinal)
        {
            string sql = "UPDATE Comandas SET total = @total, descuento = @descuento, precioFinal = @precioFinal, activa = 0 WHERE nroComanda = @nroComanda;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("total", SqlDbType.Float);
                Cx.sqlCmd.Parameters[0].Value = total;

                Cx.sqlCmd.Parameters.Add("descuento", SqlDbType.Float);
                Cx.sqlCmd.Parameters[1].Value = descuento;

                Cx.sqlCmd.Parameters.Add("precioFinal", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = precioFinal;

                Cx.sqlCmd.Parameters.Add("nroComanda", SqlDbType.Int);
                Cx.sqlCmd.Parameters[3].Value = nroComanda;

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

        public static DataTable TraerUnaComanda(int nroComanda)
        {
            DataTable comanda = new DataTable("Comanda");

            string sql = "SELECT nroComanda, fecha, nroMesa, activa, total, descuento, precioFinal, cuilMozo FROM Comandas WHERE nroComanda = @nroComanda";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nroComanda", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = nroComanda;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(comanda);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                comanda = null;
            }

            return comanda;
        }

        public static String NombreMozo(long cuil)
        {
            string sql = "SELECT CONCAT(nombre,' ', apellido) as nya FROM Personas WHERE cuil = @cuil";

            string nombre;
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("@cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuil;

                Cx.Abrir();
                SqlDataReader reader = Cx.sqlCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    nombre = reader.GetString(0);
                }
                else
                {
                    nombre = "";
                }
                return nombre;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return "";
            }
        }

        public static Boolean ComandaDeMesaActiva(int nroMesa)
        {
            string sql = "SELECT baja FROM Comandas WHERE nroMesa = @nroMesa AND activa = 1";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@nroMesa", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = nroMesa;

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
                return true;
            }
        }
    }
}
