using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class Producto
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

        }

        //Getters y Setters

        public int CodProd { get => codProd; set => codProd = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string DescProd { get => descProd; set => descProd = value; }
        public bool Compuesto { get => compuesto; set => compuesto = value; }
        public bool Error { get => error; set => error = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }

        //Funciones


    }
}
