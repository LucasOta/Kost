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
        private double stock;
        private bool insumo;
        private int unidad;
        private double contenido;


        //Constructores
        public ProdSimple()
        {
            
        }

        public ProdSimple(int stock, bool insumo, string nombre, float precioVenta, int idCat, string desc, bool comp, int unidad, double contenido)
        {
            Error = false;
            Mensaje = "";
            Stock = stock;
            Insumo = insumo;
            Nombre = nombre;
            PrecioVenta = precioVenta;
            IdCategoria = idCat;
            DescProd = desc;
            Compuesto = comp;
            Unidad = unidad;
            Contenido = contenido;

            this.GuardarPS();
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

        public double Stock
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
        public void GuardarPS()
        {
            if (CapaDatos.ProductoBD.Guardar(Nombre, DescProd, IdCategoria, PrecioVenta, false, 0, insumo, Unidad, Contenido)  > 0)
            {
                Error = false;
                Mensaje = "Producto simple guardado con éxito. ";
            }
            else
            {
                Error = true;
                Mensaje = "Ocurrió un error durante la conexión con BD, intente nuevamente. ";
            }
        }        

        public Boolean ModificarPS()
        {
            if(this.ModificarProducto() && CapaDatos.ProdSimpleBD.Modificar(CodProdSimple, Stock, Insumo, Unidad, Contenido))
            {
                Mensaje = "Los cambios se guardaron correctamente. ";
                return true;
            }
            else
            {
                Mensaje = "Ocurrió un error durante la conexión con BD, algunos datos pueden no concordar. ";
                return false;
            }
        }

        //public static Boolean EliminarPS(int codPS)
        //{
        //    return CapaDatos.ProdSimpleBD.Eliminar(codPS);
        //}

        public static void TraerUnSimple(int codPS, ProdSimple p)
        {
            Producto.TraerUnProducto(codPS, p);

            DataTable prods = CapaDatos.ProdSimpleBD.TraerUnProdSimple(codPS);

            DataRow rowps = prods.Rows[0];

            p.CodProdSimple = Convert.ToInt32(rowps["codProdSimple"].ToString());
            p.Stock = Convert.ToDouble(rowps["stock"].ToString());
            p.Unidad = Convert.ToInt32(rowps["unidad"].ToString());
            p.Contenido = Convert.ToDouble(rowps["contenido"].ToString());
            if ((rowps["insumo"].ToString()).Equals("True"))
            {
                p.Insumo = true;
            }
            else
            {
                p.Insumo = false;
            }
        }

        public static DataTable MostrarStock()
        {
            return CapaDatos.ProdSimpleBD.MostrarStock();
        }

        public Boolean ActualizarStock()
        {
            return CapaDatos.ProdSimpleBD.ActualizarStock(CodProdSimple, Stock);
        }

        public static DataTable TraerInsumos()
        {
            return ProdSimpleBD.TraerInsumos();
        }
    }
}
