﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Producto
    {
        private int codProd;
        private string nombre;
        private float precioVenta;
        private int idCategoria;
        private string descProd;
        private bool compuesto;

        private bool error;
        private string mensaje;


        //Constructores
        public Producto()
        {

        }

        public Producto(int c_codProd, string c_nombre, float c_precioVenta, int c_idCat, string c_descProd, bool c_compuesto)
        {
            this.ValidarProd(c_codProd, c_nombre);

            if (!this.Error)
            {
                CodProd = c_codProd;
                Nombre = c_nombre;
                PrecioVenta = c_precioVenta;
                IdCategoria = c_idCat;
                DescProd = c_descProd;
                Compuesto = c_compuesto;
                //this.Guardar();
            }
            else
            {
                //Retornar mensaje
            }
        }


        //Getters y Setters
        public int CodProd
        {
            get
            {
                return codProd;
            }

            set
            {
                codProd = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public float PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
            }
        }

        public string DescProd
        {
            get
            {
                return descProd;
            }

            set
            {
                descProd = value;
            }
        }

        public bool Compuesto
        {
            get
            {
                return compuesto;
            }

            set
            {
                compuesto = value;
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
        protected void ValidarProd(int codprod, string nombre)
        {
            if (CapaDatos.ProductoBD.ExisteCodigo(CodProd))
            {
                this.Error = true;
                this.Mensaje = "Ya existe un producto guardado con este codigo de producto.";
            }

            if (CapaDatos.ProductoBD.ExisteNombre(Nombre))
            {
                this.Error = true;
                this.Mensaje += "Ya existe un producto guardado con este nombre.";
            }
        }

        //protected void Guardar()
        //{
        //    String msjGuardar = CapaDatos.ProductoBD.Guardar(Nombre, DescProd, IdCategoria, PrecioVenta, Compuesto);
        //    if (msjGuardar.Equals("OK"))
        //    {
        //        this.Error = false;
        //        this.Mensaje = "Producto guardado";
        //    }
        //    else
        //    {
        //        this.Error = true;
        //        this.Mensaje = msjGuardar;
        //    }
        //}

        public static void TraerUnProducto(int codprod, Producto p)
        {
            DataTable prod = CapaDatos.ProductoBD.TraerUnProducto(codprod);

            DataRow rowprod = prod.Rows[0];

            p.CodProd = Convert.ToInt32(rowprod["codProd"].ToString());
            p.DescProd = rowprod["descripProd"].ToString();
            p.IdCategoria = Convert.ToInt32(rowprod["idCategoria"].ToString());
            p.Nombre = rowprod["nombre"].ToString();
            p.PrecioVenta = Convert.ToSingle(rowprod["precioVenta"].ToString());
            if (rowprod["compuesto"].ToString() == "1")
            {
                p.Compuesto = true;
            }
            else
            {
                p.Compuesto = false;
            }

        }

        public Boolean ModificarProducto()
        {
            if(CapaDatos.ProductoBD.Modificar(CodProd, Nombre, DescProd, IdCategoria, PrecioVenta, Compuesto))
            {
                Mensaje = "Se guardaron los cambios con éxito";
                return true;
            }
            else
            {
                Mensaje = "Ocurrió un error durante la conexión con BD, intente nuevamente";
                return false;
            }            
        }

        public static int EliminarProd(int codprod, bool compuesto)
        {
            return ProductoBD.Eliminar(codprod, compuesto);
        }

        public static DataTable ListarTodos()
        {           
            return ProductoBD.TraerProductos();
        }

        public static Boolean ProductoActivo(int codprod)
        {
            return CapaDatos.ProductoBD.ProductoActivo(codprod);
        }

        public static DataTable TraerNoInsumos()
        {
            return ProductoBD.TraerNoInsumos();
        }

        public static float PrecioDeVenta(int codProducto)
        {
            DataTable precios = ProductoBD.PrecioVenta(codProducto);

            DataRow row = precios.Rows[0];

            if (row["precioVenta"].ToString() != "")
            {
                return Convert.ToSingle(row["precioVenta"].ToString());
            }
            return 0;
        }
    }
}
