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
        public int CodProdCompuesto { get => codProdCompuesto; set => codProdCompuesto = value; }

        //Funciones
        protected void ValidarCompuesto(int codPC)
        {
            if (ProductoCompuestoBD.existe(codPC))
            {
                this.Error = true;
                this.Mensaje += "Ya existe un producto compuesto con este codigo de producto compuesto. ";
            }
        }

        protected void GuardarPC()
        {
            base.Guardar();
            if (!Error)
            {
                if (!ProductoCompuestoBD.guardar(CodProdCompuesto))
                {
                    Error = false;
                    Mensaje = "Producto compuesto guardado con exito";
                }
                else
                {
                    Error = true;
                    Mensaje = "Ocurrio un error a nivel BD, intente nuevamente.";
                }
            }
        }

        public Boolean GuardarComposicion(int CodCom, int CodSim, int Cant)
        {
            if (!ProductoCompuestoBD.existeComposicion(CodCom, CodSim, Cant))
            {
                return ProductoCompuestoBD.guardarComposicion(CodCom, CodSim, Cant);
            }

            return true;
        }

        public static Boolean Eliminar(int CodPC)
        {
            return ProductoCompuestoBD.eliminar(CodPC);
        }

        public static Boolean EliminarComposicion(int CodCom, int CodSim, int Cant)
        {
            return ProductoCompuestoBD.eliminarComposicion(CodCom, CodSim, Cant);
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
