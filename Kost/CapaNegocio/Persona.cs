using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
     public abstract class Persona
    {
        private string nombre;
        private long cuil;
        private string apellido;
        private string direccion;
        private string mail;
        private DateTime nacimiento;


        private bool error;
        private string mensaje;

        //Constructores
        public Persona() { }

        public Persona(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {

            this.ValidarPers(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);

            if (!this.Error){
                nombre = pnombre;
                apellido = papellido;
                direccion = pdireccion;
                mail = pmail;
                cuil = pcuil;
                nacimiento = pnacimiento;
               this.Guardar(pnombre, papellido, pdireccion, pmail,  pcuil,  pnacimiento);
            } else {
                //Mandar mensaje
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

        public long Cuil
        {
            get
            {
                return cuil;
            }

            set
            {
                cuil = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public DateTime Nacimiento
        {
            get
            {
                return nacimiento;
            }

            set
            {
                nacimiento = value;
            }
        }

        //Funciones

        protected void ValidarPers(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            if (!Validaciones.Nombre(pnombre)) {
                this.Error = true;
                this.Mensaje += "el nombre contiene caracteres raros";
            }
            if (!Validaciones.Apellido(papellido))
            {
                this.Error = true;
                this.Mensaje += "el apellido contiene caracteres raros";
            }
            if (!Validaciones.Direccion(pdireccion))
            {
                this.Error = true;
                this.Mensaje += "el direccion contiene caracteres raros";
            }
            if (!Validaciones.Mail(pmail))
            {
                this.Error = true;
                this.Mensaje += "el mail contiene caracteres raros";
            }
            if (!Validaciones.Cuil(pcuil))
            {
                this.Error = true;
                this.Mensaje += "el cuil contiene caracteres raros";
            }
            if (!Validaciones.Nacimiento(pnacimiento))
            {
                this.Error = true;
                this.Mensaje += "el nacimiento contiene caracteres raros";
            }

        }

        protected void Guardar(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            //Esto de abajo es por si hay un error al guardar
            if (!CapaDatos.PersonaBD.existe(pcuil))//Persona_bd.Save(this.nombre, this.apellido, this.direccion, this.dni))
            {
                String msjGuardar = CapaDatos.PersonaBD.guardar(pcuil, pnombre, papellido, pmail, pnacimiento, pdireccion);
                if (msjGuardar.Equals("OK"))//Persona_bd.Save(this.nombre, this.apellido, this.direccion, this.dni))
                {
                    this.Error = false;
                    this.Mensaje = "Persona Guardada";
                }
                else
                {
                    this.Error = true;
                    this.Mensaje = msjGuardar;
                }
            }
            else
            {
                this.Error = true;
                this.Mensaje = "Ya existe una persona cargada en el sistema con ese nro de Cuil";
            }
        }

        public static void TraerUnaPersona(long cuil, Persona p)
        {
            DataTable pers = CapaDatos.PersonaBD.TraerUnaPersona(cuil);

            DataRow rowper = pers.Rows[0];

            p.Nombre = rowper["nombre"].ToString();
            p.Apellido = rowper["apellido"].ToString();
            p.Direccion = rowper["direccion"].ToString();
            p.Mail = rowper["mail"].ToString();
            p.Cuil = Convert.ToInt64(rowper["cuil"].ToString());
            p.Nacimiento = Convert.ToDateTime(rowper["fechaNacimiento"].ToString());
        }

        public static Boolean ModificarPersona(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            return CapaDatos.PersonaBD.modificar(pcuil, pnombre, papellido, pmail, pnacimiento, pdireccion);
        }

        public static Boolean PersonaActiva(long cuil)
        {
            return CapaDatos.PersonaBD.PersonaActiva(cuil);
        }
    }
}
