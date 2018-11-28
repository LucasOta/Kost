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
        private Boolean baja;
        private int id = -1;

        //Constructores
        public Categoria() { }

        public Categoria(string categoria, Boolean baja)
        {
            error = false;
            mensaje = "";
            this.Validar(categoria, id);
            if (!error)
            {
                Nombre = categoria;
                Baja = baja;
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

        public bool Baja
        {
            get
            {
                return baja;
            }

            set
            {
                baja = value;
            }
        }



        //Funciones

        private void Validar(string categ, int id)
        {
            if (Validaciones.Categoria(categ, id))
            {
                this.Error = true;
                this.Mensaje = "La categoria que intenta ingresar ya existe en el sistema.";
            }
        }

        public void Guardar()
        {
            if (!error)
            {
                if (CapaDatos.CategoriaBD.Guardar(Nombre, Baja))
                {
                    this.Error = false;
                    this.Mensaje = "Categoría guardada con éxito. ";
                }
                else
                {
                    this.Error = true;
                    this.Mensaje += "Ocurrió un Error durante la conexión con BD, intente nuevamente. ";
                }
            }
        }

        public static Boolean Eliminar(int id)
        {
            return CapaDatos.CategoriaBD.Eliminar(id);
        }

        public Boolean ModificarCateg()
        {
            Error = false;
            Validar(Nombre, id);
            if (!Error)
            {
                if (CapaDatos.CategoriaBD.Modificar(Id, Nombre, Baja))
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
            return CapaDatos.CategoriaBD.TraerTodos();
        }

        public static DataTable ListarAbsolutamenteTodos() //También trae las dadas de baja
        {
            return CapaDatos.CategoriaBD.TraerAbsolutamenteTodos();
        }

        public static Categoria TraerUnaCat(int id)
        {
            DataTable categ = CapaDatos.CategoriaBD.TraerUnaCategoria(id);

            DataRow rows = categ.Rows[0];

            Categoria c = new Categoria();
            c.Id = Convert.ToInt32(rows["idCategoria"].ToString());
            c.nombre = rows["nombre"].ToString();
            c.Baja = Convert.ToBoolean(rows["baja"].ToString());

            return c;
        }
    }
}
