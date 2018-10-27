using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Usuario : Persona
    {
        private string user;
        private string password;
        private int nivel;

        //Getters y Setters

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        //Constructores
        public Usuario() { }

        public Usuario(string consuser, string conspassword, int consnivel, string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            Error = false;
            Mensaje = "";
            this.Validar(consuser);
            user = consuser;
            password = conspassword;
            nivel = consnivel;
            Cuil = pcuil;
            if (!Error)
            {
                this.ValidarPers(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);
                if (!Error)
                {
                    this.Guardar(consuser, conspassword, consnivel, pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);
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
            if (Validaciones.Usuario(valuser)) {
                this.Error = true;
                this.Mensaje = "el usuario ya existe";
            }
        }

        public void Guardar(string consuser, string conspassword, int consnivel, string pnombre, string papellido, string pdireccion, string pmail, long pcuil, DateTime pnacimiento)
        {
            base.Guardar(pnombre, papellido, pdireccion, pmail, pcuil, pnacimiento);
            if (!Error)
            {
                if (!CapaDatos.UsuarioBD.existe(User))
                {
                    if (CapaDatos.UsuarioBD.guardar(User, Password, Nivel, Cuil))
                    {
                        this.Error = false;
                        this.Mensaje = "Usuario Guardado";
                    }
                    else
                    {
                        this.Error = true;
                        this.Mensaje += "Hubo un Error con la BD, intente nuevamente";
                    }
                }
                else
                {
                    this.Error = true;
                    this.Mensaje = "Ya existe un usuario cargado en el sistema con ese nick";
                }
            }
            else {
                if(this.Mensaje == "Ya existe una persona cargada en el sistema con ese nro de Cuil")
                {
                    if (!CapaDatos.PersonaBD.PersonaActiva(pcuil))
                    {
                        this.Mensaje = "Persona no activa";
                    }
                }

            }                

        }

        public static Boolean Eliminar(long cuil) {
            return CapaDatos.UsuarioBD.eliminar(cuil);
            //Ver lo de cascada con haspert
        }

        public static Boolean ModificarUsuario(string user, string password, int nivel, long cuil, string pnombre, string papellido, string pdireccion, string pmail, DateTime pnacimiento)
        {
            Boolean usu = CapaDatos.UsuarioBD.modificar(user, password, nivel, cuil);

            Boolean per = Persona.ModificarPersona(pnombre, papellido, pdireccion, pmail, cuil, pnacimiento);

            if(usu && per)
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
            return UsuarioBD.Get_all();
        }

        public static Usuario TraerUnUsuario(long cuil)
        {
            DataTable usuar = CapaDatos.UsuarioBD.TraerUnUsuario(cuil);

            DataRow rowus = usuar.Rows[0];

            Usuario user = new Usuario();

            Persona.TraerUnaPersona(cuil, user);
            
            user.User = rowus["usuario"].ToString();
            user.Password = rowus["contrasenia"].ToString();
            user.Nivel = Convert.ToInt32(rowus["nivel"].ToString());

            return user;
        }

        public static int InicioSesion(string user, string pass) {
            return CapaDatos.UsuarioBD.InicioSesion(user, pass);
        }
    }
}
