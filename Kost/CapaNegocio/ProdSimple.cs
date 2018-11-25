﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ProdSimple : Producto
    {
        private int codProdSimple;
        private int stock;
        private bool insumo;
        private int unidad;
        private double contenido;


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
        public int CodProdSimple
        {
            get
            {
                return codProdSimple;
            }

            set
            {
                codProdSimple = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public bool Insumo
        {
            get
            {
                return insumo;
            }

            set
            {
                insumo = value;
            }
        }

        public int Unidad
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }

        public double Contenido
        {
            get
            {
                return contenido;
            }

            set
            {
                contenido = value;
            }
        }


        //Funciones 
        protected void ValidarSimple(int codPS)
        {
            if (CapaDatos.ProdSimpleBD.Existe(codPS))
            {
                Error = true;
                Mensaje += "Ya existe un producto simple con este codigo de producto simple. ";
            }
        }

        public void GuardarPS()
        {
            if (!Error)
            {
                if(CapaDatos.ProductoBD.Guardar(Nombre, DescProd, IdCategoria, PrecioVenta, false, 0, insumo, Unidad, Contenido)  > 0)
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

                Boolean prodSimp = CapaDatos.ProdSimpleBD.Modificar(CodProdSimple, Stock, Insumo, 0, 0);

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
            return CapaDatos.ProdSimpleBD.Eliminar(codPS);
        }

        public static void TraerUnSimple(int codPS, ProdSimple p)
        {
            Producto.TraerUnProducto(codPS, p);

            DataTable prods = CapaDatos.ProdSimpleBD.TraerUnProdSimple(codPS);

            DataRow rowps = prods.Rows[0];

            p.CodProdSimple = Convert.ToInt32(rowps["codProdSimple"].ToString());
            p.Stock = Convert.ToInt32(rowps["stock"].ToString());
        }

        public static DataTable MostrarStock()
        {
            return CapaDatos.ProdSimpleBD.MostrarStock();
        }

        public Boolean ActualizarStock()
        {
            return CapaDatos.ProdSimpleBD.ActualizarStock(CodProdSimple, Stock);
        }
    }
}
