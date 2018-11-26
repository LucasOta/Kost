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
        private bool usuario;

        private bool error;
        private string mensaje;

        //Constructores
        public Persona() { }

        public Persona(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento, bool usuario)
        {

            this.ValidarPers(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);

            if (!this.Error){
                Nombre = pnombre;
                Apellido = papellido;
                Direccion = pdireccion;
                Mail = pmail;
                Cuil = pcuil;
                Nacimiento = pnacimiento;
                Usuario = usuario;
                this.Guardar();
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

        public bool Usuario { get => usuario; set => usuario = value; }


        //Funciones
        protected void ValidarPers(string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            if (!Validaciones.Nombre(pnombre)) {
                this.Error = true;
                this.Mensaje += "el nombre contiene caracteres raros.";
            }
            if (!Validaciones.Apellido(papellido))
            {
                this.Error = true;
                this.Mensaje += "el apellido contiene caracteres raros.";
            }
            if (!Validaciones.Direccion(pdireccion))
            {
                this.Error = true;
                this.Mensaje += "el direccion contiene caracteres raros.";
            }
            if (!Validaciones.Mail(pmail))
            {
                this.Error = true;
                this.Mensaje += "el mail contiene caracteres raros.";
            }
            if (!Validaciones.Cuil(pcuil))
            {
                this.Error = true;
                this.Mensaje += "el cuil contiene caracteres raros.";
            }
            if (!Validaciones.Nacimiento(pnacimiento))
            {
                this.Error = true;
                this.Mensaje += "el nacimiento contiene caracteres raros.";
            }

        }

        protected void Guardar() 
        {
            
            if (!CapaDatos.PersonaBD.Existe(Cuil))
            {
                String msjGuardar = CapaDatos.PersonaBD.Guardar(Cuil, Nombre, Apellido, Mail, Nacimiento, Direccion, Usuario);
                if (msjGuardar.Equals("OK"))
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

        public Boolean ModificarPersona()
        {
            Error = false;
            Mensaje = "";
            this.ValidarPers(Nombre, Apellido, Direccion, Mail, Cuil, Nacimiento);
            if (!Error)
            {
                return CapaDatos.PersonaBD.Modificar(Cuil, Nombre, Apellido, Mail, Nacimiento, Direccion);
            }
            else
            {
                Mensaje += " No pudieron guardarse las modificaciones.";
                return false;
            }          
        }

        public static Boolean PersonaActiva(long cuil)
        {
            return CapaDatos.PersonaBD.PersonaActiva(cuil);
        }
    }
}
