using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kost
{
    public delegate void Inicio_0_EventHandler();
    public delegate void Inicio_1_EventHandler();
    public delegate void Inicio_2_EventHandler();

    public delegate void Cerrar_LoginEventHandler();

    public partial class Login : UserControl
    {
        public event Inicio_0_EventHandler Inicio_0;
        public event Inicio_1_EventHandler Inicio_1;
        public event Inicio_2_EventHandler Inicio_2;

        public event Cerrar_LoginEventHandler Cerrar;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals("")) {
                CapaNegocio.Funciones.mError(this, "Por Favor, complete los datos de inicio de sesión");
            }
            else {
                switch (CapaNegocio.Usuario.InicioSesion(txtUsuario.Text, txtContraseña.Text))
                {
                    case 0:
                        this.Inicio_0();
                        CapaNegocio.Funciones.mError(this, "Error al iniciar sesión, verifique el usuario y la contraseña.");
                        this.Clear();
                        break;
                    case 1:
                        this.Inicio_1();
                        break;
                    case 2:
                        this.Inicio_2();
                        break;

                }
                            
            }
        }

        public void Clear() {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Cerrar();
        }
    }
}
