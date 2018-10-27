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
        public static Boolean existe(int codProd)
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
            catch (Exception e)
            {
                return true; //Habría que ver qué mandar si hay un error con la conexión
            }
        }

        public static Boolean existe(string nombre)
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
            catch (Exception e)
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
            catch (Exception e)
            {
                return true; //Habría que ver qué mandar si hay un error con la conexión
            }
        }

        public static Boolean modificar(long pCuil, string pNombre, string pApellido, string pMail, DateTime pFechaNac, string pDireccion)
        {
            string sql = "UPDATE Personas SET nombre=@nombre, apellido=@apellido, mail=@mail, fechaNacimiento=@fechaNacimiento, direccion=@direccion, baja=0 WHERE cuil=@CUIL;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);



                Cx.sqlCmd.Parameters.Add("nombre", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = pNombre;

                Cx.sqlCmd.Parameters.Add("apellido", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[1].Value = pApellido;

                Cx.sqlCmd.Parameters.Add("mail", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[2].Value = pMail;

                Cx.sqlCmd.Parameters.Add("fechaNacimiento", SqlDbType.Date);
                Cx.sqlCmd.Parameters[3].Value = pFechaNac;

                Cx.sqlCmd.Parameters.Add("direccion", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[4].Value = pDireccion;

                Cx.sqlCmd.Parameters.Add("CUIL", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[5].Value = pCuil;


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

        public static Boolean eliminar(long pCuil)
        {
            string sql = "UPDATE Personas SET baja=@baja WHERE cuil=@CUIL;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("CUIL", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[1].Value = pCuil;

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
            catch (Exception e)
            {
                return false;
            }
        }

        public static DataTable DataGridUsuarios()
        {
            DataTable ds = new DataTable("dataGridUsuarios");

            string sql = "SELECT idMedio, medioDePago, borrado FROM Personas WHERE baja=0";

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

        public static DataTable TraerUnaPersona(long cuil)
        {
            DataTable persona = new DataTable("Usuarios");

            string sql = "SELECT * FROM Personas WHERE cuil = @cuil";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuil;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(persona);
            }
            catch (Exception e)
            {
                persona = null;
            }

            return persona;
        }
    }
}

