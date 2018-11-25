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
    class ProdCompuesto : Producto
    {
        private int codProdCompuesto;

        //Constructores
        public ProdCompuesto()
        {

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


        //Funciones
        protected void ValidarCompuesto(int codPC)
        {
            if (ProductoCompuestoBD.Existe(codPC))
            {
                this.Error = true;
                this.Mensaje += "Ya existe un producto compuesto con este codigo de producto compuesto. ";
            }
        }

        protected void GuardarPC()
        {
            if (!Error)
            {
                if (ProductoBD.Guardar(Nombre, DescProd, IdCategoria, PrecioVenta, true, 0, false, 0, 0) > 0)
                {
                    Error = false;
                    Mensaje = "Producto compuesto guardado con éxito";
                }
                else
                {
                    Error = true;
                    Mensaje = "Ocurrió un error durante la conexión con BD, intente nuevamente.";
                }
            }
        }

        public Boolean GuardarComposicion(int CodCom, int CodSim, int Cant)
        {
            if (!ProductoCompuestoBD.ExisteComposicion(CodCom, CodSim, Cant))
            {
                return ProductoCompuestoBD.GuardarComposicion(CodCom, CodSim, Cant);
            }

            return true;
        }

        public static Boolean Eliminar(int CodPC)
        {
            return ProductoCompuestoBD.Eliminar(CodPC);
        }

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
