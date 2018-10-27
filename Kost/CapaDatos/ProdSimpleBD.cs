using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProdSimpleBD
    {
        public static Boolean existe(int codProdSimpl)
        {
            string sql = "SELECT baja FROM ProdSimples WHERE codProdSimple =  @codProdSimpl";
            try
            {
                Conexion cx = new Conexion();
                cx.setComandoTexto();
                cx.setSQL(sql);

                cx.sqlCmd.Parameters.Add("@codProdSimpl", SqlDbType.Int);
                cx.sqlCmd.Parameters[0].Value = codProdSimpl;

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


        public static bool guardar(int pCod, int pStock, bool pInsumo)
        {
            string sql = "INSERT INTO ProdSimples (pCod, stock, insumo, baja) values (@pCod, @pStock, @pInsumo, @baja)";

            try
            {
                Conexion Cx = new Conexion();

                Cx.setComandoTexto();
                Cx.setSQL(sql);

                Cx.sqlCmd.Parameters.Add("pCod", SqlDbType.Int);
                Cx.sqlCmd.Parameters[0].Value = pCod;

                Cx.sqlCmd.Parameters.Add("pStock", SqlDbType.Int);
                Cx.sqlCmd.Parameters[1].Value = pStock;

                Cx.sqlCmd.Parameters.Add("pInsumo", SqlDbType.Bit);
                Cx.sqlCmd.Parameters[2].Value = pInsumo;
                
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
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
