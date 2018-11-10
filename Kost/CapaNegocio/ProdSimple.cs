﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    class ProdSimple : Producto
    {
        private int codProdSimple;
        private int stock;
        private bool insumo;

        //Constructores

        public ProdSimple()
        {

        }

        public ProdSimple(int codPS, int stock, bool insumo, int codprod, string nombre, float precioVenta, int idCat, string desc, bool comp)
        {
            Error = false;
            Mensaje = "";
            this.ValidarSimple(codPS);
            if (!Error)
            {
                CodProdSimple = codPS;
                Stock = stock;
                Insumo = insumo;

                this.ValidarProd(codprod, nombre);
                if (!Error)
                {
                    Nombre = nombre;
                    PrecioVenta = precioVenta;
                    IdCategoria = idCat;
                    DescProd = desc;
                    Compuesto = comp;

                    this.GuardarPS();
                }
                else
                {
                    Error = true;
                }
            }
            else
            {
                Error = true;
            }
        }

        //Getters y Setters

        public int CodProdSimple { get => codProdSimple; set => codProdSimple = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool Insumo { get => insumo; set => insumo = value; }

        //Funciones 

        protected void ValidarSimple(int codPS)
        {
            if (!CapaDatos.ProdSimpleBD.existe(codPS))
            {
                Error = true;
                Mensaje = "Ya existe un producto simple con este codigo.";
            }
        }

        protected void GuardarPS()
        {
            base.Guardar();
            if (!Error)
            {
                if(CapaDatos.ProdSimpleBD.guardar(CodProdSimple, Stock, Insumo))
                {
                    Error = false;
                    Mensaje = "Producto simple guardado";
                }
                else
                {
                    Error = true;
                    Mensaje = "Hubo un error a nivel BD, intente nuevamente";
                }
            }
        }

        public Boolean ModificarPS()
        {
            Error = false;
            this.ValidarSimple(CodProdSimple);

            if (!Error)
            {
                Boolean prod = this.ModificarProducto();

                Boolean prodSimp = CapaDatos.ProdSimpleBD.modificar(CodProdSimple, Stock, Insumo);

                if(prod && prodSimp)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Mensaje += " No pudieron relizarse las modificaciones";
                return false;
            }
        }

        public static Boolean EliminarPS(int codPS)
        {
            return CapaDatos.ProdSimpleBD.eliminar(codPS);
        }

        public static void TraerUnSimple(int codPS, ProdSimple p)
        {
            DataTable prod = CapaDatos.ProdSimpleBD.TraerUnProdSimple(codPS);

            DataRow rowp = prod.Rows[0];

            p.CodProdSimple = Convert.ToInt32(rowp["codProdSimple"].ToString());
            p.Stock = Convert.ToInt32(rowp["stock"].ToString());
            if (Convert.ToInt32(rowp["insumo"].ToString()) == 1)
            {
                p.Insumo = true;
            }
            else
            {
                p.Insumo = false;
            }
        }

        public DataTable MostrarStock()
        {
            return CapaDatos.ProdSimpleBD.MostrarStock();
        }
    }
}