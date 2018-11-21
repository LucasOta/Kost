using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Categoria
    {
        private bool error;
        private string mensaje;
        private string nombre;
        private int id;
        public Categoria() { }

        public Categoria(string categoria)
        {
            error = false;
            mensaje = "";
            this.Validar(categoria);
            if (!error)
            {
                Nombre = categoria;
                this.Guardar();
            }
            else
            {
                error = true;
            }
        }


        //Getters y Setters
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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }



        //Funciones

        private void Validar(string categ)
        {
            if (Validaciones.Categoria(categ))
            {
                this.error = true;
                this.mensaje = "La categoria ya existe";
            }
        }

        public void Guardar()
        {
            if (!error)
            {
                if (CapaDatos.CategoriaBD.guardar(Nombre))
                {
                    this.error = false;
                    this.mensaje = "Categoría guardada";
                }
                else
                {
                    this.error = true;
                    this.mensaje += "Hubo un Error con la BD, intente nuevamente";
                }
            }
        }

        public static Boolean Eliminar(int id)
        {
            return CapaDatos.CategoriaBD.eliminar(id);
        }

        public Boolean ModificarCateg()
        {
            Error = false;
            Validar(Nombre);
            if (!Error)
            {
                if (CapaDatos.CategoriaBD.modificar(Id, Nombre))
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
                Mensaje += " No pudieron guardarse las modificaciones.";
                return false;
            }
        }

        public static DataTable ListarTodos()
        {
            return CapaDatos.CategoriaBD.Get_all();
        }

        public static Categoria TraerUnaCat(int id)
        {
            DataTable categ = CapaDatos.CategoriaBD.TraerUnaCategoria(id);

            DataRow rowus = categ.Rows[0];

            Categoria c = new Categoria();
            return c;
        }
    }
}
