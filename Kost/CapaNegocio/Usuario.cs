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
            if (!Error)
            {
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
                        Cuil = pcuil;
                        Nacimiento = pnacimiento;

                        GuardarUser();
                    }                    
                }
            }
        }


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
        

        //Funciones
        private void Validar(string valuser)
        {
            if (Validaciones.Usuario(valuser)) {
                this.Error = true;
                this.Mensaje = "El usuario ya existe. ";
            }
        }

        public void GuardarUser()
        {
            if (!Error)
            {
                if (!CapaDatos.UsuarioBD.Existe(User))
                {
                    if (PersonaBD.Guardar(Cuil, Nombre, Apellido, Mail, Nacimiento, Direccion, User, Password, Nivel, true) > 0)
                    {
                        this.Error = false;
                        this.Mensaje = "Usuario guardado con éxito.";
                    }
                    else
                    {
                        this.Error = true;
                        this.Mensaje += "Ocurrió un error con la BD, intente nuevamente. ";
                    }
                }
                else
                {
                    this.Error = true;
                    this.Mensaje = "Ya existe un usuario cargado en el sistema con ese nick. ";
                }
            }       

        }

        public static Boolean Eliminar(long cuil) {
            return CapaDatos.UsuarioBD.Eliminar(cuil);
        }

        public Boolean ModificarUsuario()
        {
            Boolean usu = CapaDatos.UsuarioBD.Modificar(this.User, this.Password, this.Nivel, this.Cuil);

            Boolean per = this.ModificarPersona();

            if (usu && per)
            {
                return true;
            }
            else
            {
                Mensaje += " No pudieron guardarse las modificaciones correctamente. Puede que algunos datos no concuerden. ";
                return false;
            }   
        }

        public static DataTable ListarTodos()
        {
            return UsuarioBD.TraerTodos();
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
