using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Detalle
    {
        private int nroComanda;
        private int nroDetalle;
        private int codProducto;
        private string descripProducto;
        private int cantidad;
        private float precioUnitario;

        private bool error;
        private string mensaje;


        //Constructores
        public Detalle()
        {

        }

        public Detalle(int nroC, int codProd, string descProd, int cant, float precioUni)
        {
            Error = false;
            Mensaje = "";
            this.Validar(cant);
            if (!Error)
            {
                NroComanda = nroC;
                CodProducto = codProd;
                DescripProducto = descProd;
                Cantidad = cant;
                PrecioUnitario = precioUni;

                this.Guardar(NroComanda, CodProducto, DescripProducto, Cantidad, PrecioUnitario);
            }
            else
            {
                Error = true;
            }
        }


        //Getters y Setters
        public int NroComanda
        {
            get
            {
                return nroComanda;
            }

            set
            {
                nroComanda = value;
            }
        }

        public int NroDetalle
        {
            get
            {
                return nroDetalle;
            }

            set
            {
                nroDetalle = value;
            }
        }

        public int CodProducto
        {
            get
            {
                return codProducto;
            }

            set
            {
                codProducto = value;
            }
        }

        public string DescripProducto
        {
            get
            {
                return descripProducto;
            }

            set
            {
                descripProducto = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public float PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }

            set
            {
                precioUnitario = value;
            }
        }

        public bool Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }


        //Funciones
        protected void Validar(int cantidad)
        {
            //Aca hay que validar que la cantidad ingresada sea coherente con la cantidad de stock que queda el producto
        }

        protected void Guardar(int nroCom, int codProd, string descProd, int cant, float precioUni)
        {
            //
        }

        public static Boolean Modificar(int codProd, int cantidad, float precioUni, string descrip)
        {
            return CapaDatos.DetalleBD.Modificar(codProd, cantidad, precioUni, descrip);
        }

        public static Boolean Eliminar(int nroDetalle)
        {
            return CapaDatos.DetalleBD.Eliminar(nroDetalle);
        }

        public static DataTable TraerTodosDetalles(int nroComanda)
        {
            return CapaDatos.DetalleBD.TraerTodosDetalles(nroComanda);
        }

        public static Detalle TraerUnDetalle(int nroDetalle)
        {
            DataTable detal = CapaDatos.DetalleBD.TraerUnDetalle(nroDetalle);

            DataRow rowus = detal.Rows[0];

            Detalle det = new Detalle();

            det.Cantidad = Convert.ToInt32(rowus["cantidad"].ToString());
            det.CodProducto = Convert.ToInt32(rowus["codProd"].ToString());
            det.DescripProducto = rowus["descripProd"].ToString();
            det.NroComanda = Convert.ToInt32(rowus["nroComanda"].ToString());
            det.NroDetalle = Convert.ToInt32(rowus["nroDetalle"].ToString());
            det.PrecioUnitario = Convert.ToInt32(rowus["precioUni"].ToString());

            return det;
        }
    }
}
