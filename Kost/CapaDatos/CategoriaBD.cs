using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CategoriaBD
    {
        //
        public static Boolean existe(string ca)
        {
            string sql = "SELECT idCategoria FROM Categorias WHERE nombre = @categoria";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                cx.sqlCmd.Parameters[0].Value = ca;

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
            catch (Exception e)
            {
                return false;
            }
        }

        public static Boolean guardar(string categoria)
        {
            string sql = "INSERT INTO Categorias (nombre, baja) values (@nombre, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("nombre", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = categoria;

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
            catch (Exception e)
            {
                return false;
            }
        }

        public static Boolean modificar(int id, string categoria)
        {
            string sql = "UPDATE Categorias SET nombre=@nombre WHERE idCategoria=@idCategoria;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = categoria;

                Cx.sqlCmd.Parameters.Add("@idCategoria", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = id;

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

        public static Boolean eliminar(int id)
        {
            string sql = "UPDATE Categorias SET baja = 1 WHERE idCategoria=@id";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("id", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = id;

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

        public static DataTable Get_all()
        {
            DataTable categorias = new DataTable("Categorias");

            string sql = "SELECT idCategoria, nombre FROM Categorias WHERE baja = 0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(categorias); //Llenamos el DataTable
            }
            catch (Exception e)
            {
                categorias = null;
            }
            return categorias;
        }

        public static DataTable TraerUnaCategoria(int id)
        {
            DataTable categoria = new DataTable("Categorias");

            string sql = "SELECT * FROM Categorias WHERE idCategoria = @id";

            try
            {
                Conexion Cx = new Conexion();
                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("@id", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = id;

                SqlDataReader Reader = Cx.sqlCmd.ExecuteReader();

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(categoria);
            }
            catch (Exception e)
            {
                categoria = null;
            }
            return categoria;
        }

    }
}


