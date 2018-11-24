using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class UsuarioBD
    {
        public static Boolean Existe(string usuario)
        {
            string sql = "SELECT baja FROM Usuarios WHERE usuario = @usuario";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cx.sqlCmd.Parameters[0].Value = usuario;

                cx.Abrir();
                SqlDataReader reader = cx.sqlCmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return false;
            }
        }

        public static Boolean Guardar(string usuario, string contrasenia, int nivel, long cuilPersona)
        {
            string sql = "INSERT INTO Usuarios (usuario, contrasenia, nivel, cuilPersona, baja) values (@usuario, @contrasenia, @nivel, @cuilPersona, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("usuario", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = usuario;

                Cx.sqlCmd.Parameters.Add("contrasenia", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[1].Value = contrasenia;

                Cx.sqlCmd.Parameters.Add("nivel", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = nivel;

                Cx.sqlCmd.Parameters.Add("cuilPersona", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[3].Value = cuilPersona;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
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

        public static Boolean Modificar(string usuario, string contrasenia, int nivel, long cuilPersona)
        {
            string sql = "UPDATE Usuarios SET usuario=@usuario, contrasenia=@contrasenia, nivel=@nivel , baja=0 WHERE cuilPersona=@cuil;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("usuario", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = usuario;

                Cx.sqlCmd.Parameters.Add("contrasenia", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[1].Value = contrasenia;

                Cx.sqlCmd.Parameters.Add("nivel", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = nivel;

                Cx.sqlCmd.Parameters.Add("cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[3].Value = cuilPersona;

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

        public static Boolean Eliminar(long cuil)
        {
            string sql = "UPDATE Usuarios SET baja = 1 WHERE cuilPersona=@cuil;" +
                "UPDATE Personas SET baja = 1 WHERE cuil=@cuil";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuil;

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

        public static DataTable TraerTodos()
        {
            DataTable usuarios = new DataTable("Usuarios");

            string sql = "SELECT CONCAT (nombre,' ', apellido)as nya, P.cuil FROM Personas P INNER JOIN Usuarios U ON P.cuil=U.cuilPersona WHERE P.baja = 0 AND U.baja = 0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(usuarios); //Llenamos el DataTable
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            }catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                usuarios = null;
            }
            return usuarios;
        }

        public static DataTable TraerUnUsuario(long cuil)
        {
            DataTable usuario = new DataTable("Usuarios");

            string sql = "SELECT * FROM Usuarios WHERE cuilPersona = @cuil";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuil;

                //SqlDataReader Reader = Cx.sqlCmd.ExecuteReader();

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(usuario);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                usuario = null;
            }
            return usuario;
        }

        public static int InicioSesion(string user, string pass) {
            string sql = "SELECT nivel FROM Usuarios WHERE usuario = @usuario and contrasenia = @contrasenia;";
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cx.sqlCmd.Parameters[0].Value = user;

                cx.sqlCmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
                cx.sqlCmd.Parameters[1].Value = pass;

                cx.Abrir();
                SqlDataReader reader = cx.sqlCmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return 0;
                }
                else
                {
                    reader.Read();
                    return Convert.ToInt32(reader.GetInt32(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
