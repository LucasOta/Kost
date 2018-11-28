using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class ProdCompuesto : Producto
    {
        private int codProdCompuesto;

        //Constructores
        public ProdCompuesto()
        {

        }

        public ProdCompuesto(string nombre, float precioVenta, int idCat, string desc, bool comp, DataTable composicion)
        {
            Error = false;
            Mensaje = "";
            Nombre = nombre;
            PrecioVenta = precioVenta;
            IdCategoria = idCat;
            DescProd = desc;
            Compuesto = comp;

            this.GuardarPC();

            foreach(DataRow row in composicion.Rows)
            {
                if (!GuardarComposicion(Convert.ToInt32(row["codProdSim"].ToString()), Convert.ToInt32(row["cantidad"])))
                {
                    Error = true;
                    Mensaje = "Ocurrió un error durante la carga de los elementos que componen al productos.";
                }
            }
        }

        //Getters y Setters
        public int CodProdCompuesto
        {
            get
            {
                return codProdCompuesto;
            }

            set
            {
                codProdCompuesto = value;
            }
        }


        //Funcione
        protected void GuardarPC()
        {
            if (ProductoBD.Guardar(Nombre, DescProd, IdCategoria, PrecioVenta, true, 0, false, 0, 0) > 0)
            {
                Error = false;
                Mensaje = "Producto compuesto guardado con éxito. ";
            }
            else
            {
                Error = true;
                Mensaje = "Ocurrió un error durante la conexión con BD, intente nuevamente. ";
            }            
        }

        public Boolean GuardarComposicion(int CodSim, int Cant)
        {
            return ProductoCompuestoBD.GuardarComposicion(CodSim, Cant);
        }

        public static Boolean GuardarComposicionMod(int CodCom, int CodSim, int Cant)
        {
            return CapaDatos.ProductoCompuestoBD.GuardarComposicionMod(CodCom, CodSim, Cant);
        }

        //public static Boolean Eliminar(int CodPC)
        //{
        //    return ProductoCompuestoBD.Eliminar(CodPC);
        //}

        public static Boolean EliminarComposicion(int CodCom, int CodSim, int Cant)
        {
            return ProductoCompuestoBD.EliminarComposicion(CodCom, CodSim, Cant);
        }

        public static DataTable TraerComposicion(int cod)
        {
            return ProductoCompuestoBD.TraerComposicion(cod);
        } 

        public static DataTable TraerUnProdCompuesto(int cod)
        {
            return ProductoCompuestoBD.TraerUnProdCompuesto(cod);
        }
    }
}
