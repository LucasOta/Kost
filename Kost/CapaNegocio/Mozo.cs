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
                    Nombre = pnombre;
                    Apellido = papellido;
                    Direccion = pdireccion;
                    Mail = pmail;
                    Cuil = pcuil;
                    Nacimiento = pnacimiento;

                   GuardarMozo();
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
        public void GuardarMozo()
        {
            base.Guardar();
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
                if (CapaDatos.MozoBD.existe(Cuil))
                {
                    this.Error = true;
                    this.Mensaje = "Ya existe un mozo cargado en el sistema con ese cuil";
                    if (!CapaDatos.PersonaBD.PersonaActiva(Cuil))
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

        public Boolean ModificarMozo()
        {
            Boolean moz = CapaDatos.MozoBD.modificar(this.Cuil);

            Boolean per = this.ModificarPersona();

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
