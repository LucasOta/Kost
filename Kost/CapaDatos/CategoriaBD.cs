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
        
        public static Boolean Existe(string ca, int id)
        {
            string sql;
            if (id > 0)
            {
                sql = "SELECT baja FROM Categorias WHERE nombre = @categoria AND  NOT idCategoria = @ID";
            }
            else
            {
                sql = "SELECT baja FROM Categorias WHERE nombre = @categoria";
            }
             
            try
            {
                Conexion cx = new Conexion();
                cx.SetComandoTexto();
                cx.SetSQL(sql);

                cx.sqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                cx.sqlCmd.Parameters[0].Value = ca;

                cx.sqlCmd.Parameters.Add("@ID", SqlDbType.Int);
                cx.sqlCmd.Parameters[1].Value = id;

                cx.Abrir();
                SqlDataReader reader = cx.sqlCmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    cx.Cerrar();
                    return false;
                }
                else
                {
                    cx.Cerrar();
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

        public static Boolean Guardar(string categoria, Boolean baja)
        {
            string sql = "INSERT INTO Categorias (nombre, baja) values (@nombre, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("nombre", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = categoria;

                Cx.sqlCmd.Parameters.Add("baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[1].Value = baja;

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

        public static Boolean Modificar(int id, string categoria, Boolean baja)
        {
            string sql = "UPDATE Categorias SET nombre=@nombre, baja=@baja WHERE idCategoria=@idCategoria;";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.sqlCmd.Parameters[0].Value = categoria;

                Cx.sqlCmd.Parameters.Add("@baja", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[1].Value = baja;

                Cx.sqlCmd.Parameters.Add("@idCategoria", SqlDbType.Int);
                Cx.sqlCmd.Parameters[2].Value = id;

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

        public static Boolean Eliminar(int id)
        {
            string sql = "UPDATE Categorias SET baja = 1 WHERE idCategoria=@id";

            try
            {
                Conexion Cx = new Conexion();

                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("id", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = id;

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
            DataTable categorias = new DataTable("Categorias");

            string sql = "SELECT idCategoria, nombre, baja FROM Categorias WHERE baja = 0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(categorias); //Llenamos el DataTable
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                categorias = null;
            }
            return categorias;
        }

        public static DataTable TraerAbsolutamenteTodos()//También trae las dadas de baja
        {
            DataTable categorias = new DataTable("Categorias");

            string sql = "SELECT idCategoria, nombre, baja FROM Categorias";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(categorias); //Llenamos el DataTable
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                categorias = null;
            }
            return categorias;
        }

        public static DataTable TraerUnaCategoria(int id)
        {
            DataTable categoria = new DataTable("Categoria");

            string sql = "SELECT idCategoria, nombre, baja FROM Categorias WHERE idCategoria = @id";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.sqlCmd.Parameters.Add("@id", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = id;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(categoria);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                categoria = null;
            }
            return categoria;
        }

    }
}


