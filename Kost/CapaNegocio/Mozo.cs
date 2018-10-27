using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Mozo : Persona
    {
        //Getters y Setters

        
        //Constructores
        public Mozo() { }

        public Mozo(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            Error = false;
            Mensaje = "";
            Cuil = pcuil;
            if (!Error)
            {
                this.ValidarPers(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);
                if (!Error)
                {
                    this.Guardar(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);
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


        //Funciones

        private void Validar(string valuser)
        {
            if (Validaciones.Usuario(valuser))
            {
                this.Error = true;
                this.Mensaje = "El mozo ya existe";
            }
        }

        public void Guardar(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            base.Guardar(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);
            if (!Error)
            {
                if (CapaDatos.MozoBD.guardar(Cuil))
                {
                    this.Error = false;
                    this.Mensaje = "Mozo Guardado";
                }
                else
                {
                    this.Error = true;
                    this.Mensaje += "Hubo un Error con la BD, intente nuevamente";
                }             
            }
            else
            {
                if (CapaDatos.MozoBD.existe(pcuil))
                {
                    this.Error = true;
                    this.Mensaje = "Ya existe un mozo cargado en el sistema con ese cuil";
                    if (!CapaDatos.PersonaBD.PersonaActiva(pcuil))
                    {
                        this.Mensaje = "Cuil existente no activo";
                    }
                }
                else
                {
                    this.Error = true;
                    this.Mensaje += " .Hubo un Error, intente nuevamente";
                }   
            }
        }

        public static Boolean Eliminar(long cuil)
        {
            return CapaDatos.MozoBD.eliminar(cuil);
            //Ver lo de cascada con haspert
        }

        public static Boolean ModificarMozo(long cuil, string pnombre, string papellido, string pdireccion, string pmail, DateTime pnacimiento)
        {
            Boolean moz = CapaDatos.MozoBD.modificar(cuil);

            Boolean per = Persona.ModificarPersona(pnombre, papellido, pdireccion, pmail, cuil, pnacimiento);

            if (moz && per)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable ListarTodos()
        {
            return MozoBD.Get_all();
        }

        public static Mozo TraerUnMozo(long cuil)
        {
            DataTable mozo = CapaDatos.MozoBD.TraerUnMozo(cuil);

            DataRow rowus = mozo.Rows[0];

            Mozo mozoo = new Mozo();

            Persona.TraerUnaPersona(cuil,mozoo);

            return mozoo;
        }
    }
}
