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
            this.ValidarPers(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);

            if (!Error)
            {
                this.ExistePersonaCargada(pcuil);
                if (!Error)
                {
                    Nombre = pnombre;
                    Apellido = papellido;
                    Direccion = pdireccion;
                    Mail = pmail;
                    Nacimiento = pnacimiento;

                    GuardarMozo();
                }
            }
        }


        //Funciones
        public void GuardarMozo()
        {
            if (!Error)
            {
                if (PersonaBD.Guardar(Cuil, Nombre, Apellido, Mail, Nacimiento, Direccion, " ", " ", 0, false) > 0)
                {
                    this.Error = false;
                    this.Mensaje = "Mozo Guardado con éxito. ";
                }
                else
                {
                    this.Error = true;
                    this.Mensaje += "Ocurrió un Error durante la conexión con BD, intente nuevamente. ";
                }             
            }
            else
            {
                if (CapaDatos.MozoBD.Existe(Cuil))
                {
                    this.Error = true;
                    this.Mensaje = "Ya existe un mozo cargado en el sistema con ese cuil. ";
                }
                else
                {
                    this.Error = true;
                    this.Mensaje += " .Ocurrió un Error, intente nuevamente. ";
                }   
            }
        }

        public static Boolean Eliminar(long cuil)
        {
            return CapaDatos.MozoBD.Eliminar(cuil);
        }

        public Boolean ModificarMozo()
        {
            Boolean moz = CapaDatos.MozoBD.Modificar(this.Cuil);

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
            return MozoBD.TraerTodos();
        }

        public static Mozo TraerUnMozo(long cuil)
        {
            Mozo mozoo = new Mozo();

            Persona.TraerUnaPersona(cuil,mozoo);

            return mozoo;
        }
    }
}
