using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaNegocio;


namespace Kost
{
    public partial class Usuarios : UserControl, Interfaz
    {
        Boolean banderaGuardar = true;
        Boolean eraMozo = false;
        Usuario user = new Usuario();

        public Usuarios()
        {
            InitializeComponent();            
        }


        //Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                CapaNegocio.Usuario usuario = new CapaNegocio.Usuario(txtUsuario.Text, txtContraseña.Text, Convert.ToInt16(cbxNivel.SelectedValue), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtMail.Text, Convert.ToInt64(txtCuil.Text.Replace("-", "")), dtpNacimiento.Value);
                if (usuario.Error)
                {
                    if(usuario.Mensaje == "Usuario no activo")
                    {
                        if (CapaNegocio.Funciones.mConsulta(this, "Existe un usuario no activo con este cuil. ¿Desea ver esos datos para soobreescribirlos? De ser la respuesta no, se creará un nuevo usuario con los datos ingresados."))
                        {
                            banderaGuardar = false;
                            eraMozo = false;
                            MostrarDatosDeUsuario(Usuario.TraerUnUsuario(usuario.Cuil));
                        }
                        else
                        {
                            user = CapaNegocio.Usuario.TraerUnUsuario(Convert.ToInt64(txtCuil.Text.Replace("-", "")));
                            eraMozo = false;
                            GuardarModificacion();
                        }
                    }else if(usuario.Mensaje == "Mozo no activo")
                    {
                        if(CapaNegocio.Funciones.mConsulta(this, "Existe un mozo no activo con este cuil. ¿Desea ver los datos que habia guardados en el sistema? De ser la respuesta no, se creará un nuevo mozo con los datos ingresados.")){
                            banderaGuardar = false;
                            Persona.TraerUnaPersona(usuario.Cuil, user);
                            eraMozo = true;
                            MostrarDatosDeUsuario(user);
                        }
                        else
                        {
                            Persona.TraerUnaPersona(usuario.Cuil, user);
                            eraMozo = true;
                            GuardarModificacion();
                        }
                    }
                    else
                    {
                        CapaNegocio.Funciones.mError(this, usuario.Mensaje);
                    }
                }
                else
                {
                    CapaNegocio.Funciones.mOk(this, "Se guardo el usuario exitosamente");
                    dgvUsuarios.DataSource = Usuario.ListarTodos();
                    Clear();
                    pnlUsuario.Enabled = false;
                }   
            }
            else
            {
                GuardarModificacion();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();

            banderaGuardar = true;

            eraMozo = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clear();
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvUsuarios.SelectedRows.Count, "un usuario", "eliminarlo.", this))
            {
                if (CapaNegocio.Funciones.mConsulta(this, "¿Esta seguro de que desea eliminar el usuario?"))
                {
                    long cuil = Convert.ToInt64(dgvUsuarios.CurrentRow.Cells["cuil"].Value);
                    if (Usuario.Eliminar(cuil))
                    {
                        Funciones.mOk(this, "Se eliminó correctamente al usuario.");
                        dgvUsuarios.DataSource = Usuario.ListarTodos();
                    }
                    else
                    {
                        Funciones.mError(this, "Error al eliminar al usuario.");
                    }
                    Clear();
                    pnlUsuario.Enabled = false;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clear();
            if (CapaNegocio.Funciones.RowSeleccionado(dgvUsuarios.SelectedRows.Count, "un usuario", "modificarlo.", this))
            {
                pnlUsuario.Enabled = true;
                txtUsuario.Enabled = false;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
                banderaGuardar = false;

                long cuil = Convert.ToInt64(dgvUsuarios.CurrentRow.Cells["cuil"].Value);
                user = CapaNegocio.Usuario.TraerUnUsuario(cuil);

                txtApellido.Text = user.Apellido;
                txtContraseña.Text = user.Password;
                txtCuil.Text = user.Cuil.ToString();
                txtDireccion.Text = user.Direccion;
                txtMail.Text = user.Mail;
                txtNombre.Text = user.Nombre;
                txtUsuario.Text = user.User;
                cbxNivel.SelectedValue = user.Nivel;
                dtpNacimiento.Value = user.Nacimiento;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clear();
            pnlUsuario.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnVerUsuario_Click(object sender, EventArgs e)
        {
            Clear();
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvUsuarios.SelectedRows.Count, "un usuario", "ver los detalles del mismo.", this))
            {
                pnlUsuario.Enabled = false;

                btnCancelar.Enabled = false;

                btnGuardar.Enabled = false;

                long cuil = Convert.ToInt64(dgvUsuarios.CurrentRow.Cells["cuil"].Value);

                MostrarDatosDeUsuario(Usuario.TraerUnUsuario(cuil));
            }
        }



        //TextBoxs
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CapaNegocio.Funciones.soloLetras(e.KeyChar);
        }
                
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CapaNegocio.Funciones.soloLetras(e.KeyChar);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CapaNegocio.Funciones.sinEspacios(e.KeyChar);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CapaNegocio.Funciones.sinEspacios(e.KeyChar);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CapaNegocio.Funciones.sinEspacios(e.KeyChar);
        }



        //Métodos      
        public void Clear()
        {
            txtApellido.Text = "";
            txtContraseña.Text = "";
            txtCuil.Text = "";
            txtDireccion.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            dtpNacimiento.Value = DateTime.Today;
            cbxNivel.SelectedValue = 1;
            pnlUsuario.Enabled = false;
        }

        private void MostrarDatosDeUsuario(Usuario user)
        {
            txtApellido.Text = user.Apellido;
            txtContraseña.Text = user.Password;
            txtCuil.Text = user.Cuil.ToString();
            txtDireccion.Text = user.Direccion;
            txtMail.Text = user.Mail;
            txtNombre.Text = user.Nombre;
            txtUsuario.Text = user.User;
            cbxNivel.SelectedValue = user.Nivel;
            dtpNacimiento.Value = user.Nacimiento;
        }

        private void GuardarModificacion()
        {
            user.User = txtUsuario.Text;
            user.Password = txtContraseña.Text;
            user.Nivel = Convert.ToInt32(cbxNivel.SelectedValue);
            user.Cuil = Convert.ToInt64(txtCuil.Text.Replace("-", ""));
            user.Nombre = txtNombre.Text;
            user.Apellido = txtApellido.Text;
            user.Direccion = txtDireccion.Text;
            user.Mail = txtMail.Text;
            user.Nacimiento = dtpNacimiento.Value;

            if (eraMozo)
            {
                if(Usuario.CrearUsuario(user.Cuil, user.User, user.Password, user.Nivel))
                {
                    if (user.ModificarUsuario())
                    {
                        CapaNegocio.Funciones.mOk(this, "La carga del nuevo usuario y cambio de datos se realizo correctamente. ");
                        dgvUsuarios.DataSource = Usuario.ListarTodos();
                        banderaGuardar = true;
                        Clear();
                        pnlUsuario.Enabled = false;
                    }
                    else
                    {
                        Funciones.mError(this, "La modificacion de los datos anteriores falló.");
                    }
                }
                else
                {
                    Funciones.mError(this, "La creacion del nuevo usuario falló.");
                }
            }
            else
            {
                if (user.ModificarUsuario())
                {
                    CapaNegocio.Funciones.mOk(this, "Los cambios al usuario se guardaron correctamente. ");
                    dgvUsuarios.DataSource = Usuario.ListarTodos();
                    banderaGuardar = true;
                    Clear();
                    pnlUsuario.Enabled = false;
                }
                else
                {
                    CapaNegocio.Funciones.mError(this, user.Mensaje);
                }
            }            

            dgvUsuarios.DataSource = Usuario.ListarTodos();
        }

        public void ActualizarPantalla()
        {
            dgvUsuarios.DataSource = Usuario.ListarTodos();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("id");
            dt.Columns.Add("Nivel");
            DataRow _ravi = dt.NewRow();
            _ravi["id"] = "1";
            _ravi["Nivel"] = "Admin";
            dt.Rows.Add(_ravi);

            _ravi = dt.NewRow();
            _ravi["id"] = "2";
            _ravi["Nivel"] = "User";
            dt.Rows.Add(_ravi);

            cbxNivel.DataSource = dt.DefaultView;
            cbxNivel.ValueMember = "id";
            cbxNivel.DisplayMember = "Nivel";
            cbxNivel.BindingContext = this.BindingContext;

            pnlUsuario.Enabled = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
