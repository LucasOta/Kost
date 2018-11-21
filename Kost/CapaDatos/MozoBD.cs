using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class MozoBD
    {
        public static Boolean existe(long cuil)
        {
            string sql = "SELECT baja FROM Mozos WHERE cuilMozo = @cuilMozo";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@cuilMozo", SqlDbType.BigInt);
                cx.sqlCmd.Parameters[0].Value = cuil;

                cx.abrir();
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

        public static Boolean guardar(long cuilMozo)
        {
            string sql = "INSERT INTO Mozos (cuilMozo, baja) values (@cuilMozo, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("cuilMozo", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuilMozo;

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

        public static Boolean modificar(long cuilMozo)
        {
            string sql = "UPDATE Mozos SET baja = 0 WHERE cuilMozo=@cuil;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("@cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuilMozo;

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

        public static Boolean eliminar(long cuil)
        {
            string sql = "UPDATE Usuarios SET baja = 1 WHERE cuilPersona=@cuil;" +
                "UPDATE Personas SET baja = 1 WHERE cuil=@cuil";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuil;

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

        public static DataTable Get_all()
        {
            DataTable mozos = new DataTable("Mozos");

            string sql = "SELECT CONCAT (P.nombre,' ', P.apellido)as nya, P.cuil FROM Personas P INNER JOIN Mozos M ON  P.cuil=M.cuilMozo WHERE P.baja = 0 and M.baja = 0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(mozos); //Llenamos el DataTable
            }
            catch (Exception e)
            {
                mozos = null;
            }
            return mozos;
        }

        public static DataTable TraerUnMozo(long cuil)
        {
            DataTable mozo = new DataTable("Usuarios");

            string sql = "SELECT * FROM Mozos WHERE cuilMozo = @cuil";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("@cuil", SqlDbType.BigInt);
                Cx.sqlCmd.Parameters[0].Value = cuil;

                //SqlDataReader Reader = Cx.sqlCmd.ExecuteReader();

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(mozo);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                mozo = null;
            }
            return mozo;
        }
    }
}
