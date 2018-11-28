﻿using System;
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
            //String msjGuardar = DetalleBD.Guardar(nroCom, codProd, descProd, cant, precioUni);
            //if ( msjGuardar.Equals("OK"))
            //{
            //    this.Error = false;
            //    this.Mensaje = "Detalle creado/guardado con éxito. ";



            //}
            //else
            //{
            //    this.Error = true;
            //    this.Mensaje = msjGuardar;
            //}

            String msjGuardar = DetalleBD.Guardar(nroCom, codProd, descProd, cant, precioUni);
            if (msjGuardar.Equals("OK"))
            {
                for (int i = 0; i < cant; i++)
                {
                    actualizar_stock(codProd, false);
                }
            }
            else
            {
                this.Error = true;
                this.Mensaje = msjGuardar;
            }
        }

        public static Boolean Modificar(int nroDet, int codProd, int cantidad, float precioUni, string descrip)
        {
            return CapaDatos.DetalleBD.Modificar(nroDet, codProd, cantidad, precioUni, descrip);
        }

        public static Boolean Eliminar(int nroDetalle)
        {
            return CapaDatos.DetalleBD.Eliminar(nroDetalle);

            //if (msjGuardar.Equals("OK"))
            //{
            //    for (int i = 0; i < cant; i++)
            //    {
            //        actualizar_stock(codProd, true);
            //    }
            //}
            //else
            //{
            //    this.Error = true;
            //    this.Mensaje = msjGuardar;
            //}
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


        private static void actualizar_stock(int codProd, Boolean suma) //si suma = true suma el stock, sino lo resta
        {
            if (ProductoBD.es_Compuesto(codProd))
            {
                DataTable composicion = ProductoCompuestoBD.TraerComposicion(codProd);
                foreach (DataRow dr in composicion.Rows)
                {
                    ProdSimpleBD.ActualizarStock(Convert.ToInt32(dr["codProdSimple"]), Convert.ToInt32(dr["cantidad"]), suma);
                }
            }
            else
            {
                ProdSimpleBD.ActualizarStock(codProd, 1, suma);
            }
        }
    }
}
