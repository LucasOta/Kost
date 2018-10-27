using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Conexion
    {
        public SqlCommand sqlCmd;
        private SqlConnection sqlCon;

        public Conexion()
        {
            string servidor = ConfigurationManager.AppSettings["server"];
            string user = ConfigurationManager.AppSettings["user_db"];
            string password = ConfigurationManager.AppSettings["password_db"];
            string baseDd = ConfigurationManager.AppSettings["base_db"];

            sqlCon = new SqlConnection();
            //1. Establecer la cadena de conexion
            sqlCon.ConnectionString = "Data Source=" + servidor + "; Initial Catalog = " + baseDd + "; User ID =" + user + "; Password =" + password;


            //sqlCon.ConnectionString = "User ID=postgres;Password=" + password +
            //                          ";Host=" + servidor + ";Port=5432;Database=drogueria";// dro2_03_18
            //2. Establecer el comando
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
            sqlCmd.CommandTimeout = 0;
        }

        public void setComandoTexto()
        {
            sqlCmd.CommandType = CommandType.Text;
        }

        public void setSQL(string query)
        {
            sqlCmd.CommandText = query;
        }

        public SqlCommand Comando()
        {
            return sqlCmd;
        }

        public void abrir()
        {
            sqlCon.Open();
        }

        public void cerrar()
        {
            sqlCon.Close();
        }
    }
}
