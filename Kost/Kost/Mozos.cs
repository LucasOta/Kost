﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Kost
{
    public partial class Mozos : UserControl
    {
        Boolean banderaGuardar = true;
        Mozo mozo;

        public Mozos()
        {
            InitializeComponent();

            dgvMozos.DataSource = Mozo.ListarTodos();
            pnlMozo.Enabled = false;
            dgvMozos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }        


        //Botones
        private void btnVer_Click_1(object sender, EventArgs e)
        {
            Clear();
            if (RowSeleccionado(dgvMozos.SelectedRows.Count, "ver los detalles del mismo.")) {
                pnlMozo.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                long cuil = Convert.ToInt64(dgvMozos.CurrentRow.Cells["cuil"].Value);
                MostrarDatosMozo(cuil);
            } 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                CapaNegocio.Mozo mozo1 = new CapaNegocio.Mozo(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtMail.Text, Convert.ToInt64(txtCuil.Text.Replace("-", "")), dtpNacimiento.Value);
                if (mozo1.Error)
                {
                    if (mozo1.Mensaje == "Cuil existente no activo")
                    {
                        if (CapaNegocio.Funciones.mConsulta(this, "Existe un mozo no activo con este cuil, ¿Desea ver esos datos para soobreescribirlos?, de ser la respuesta no, se creara un nuevo mozo con los datos que ingreso."))
                        {
                            banderaGuardar = false;
                            MostrarDatosMozo(mozo1.Cuil);
                        }
                        else
                        {
                            GuardarModificacion();
                        }
                    }
                    else
                    {
                        CapaNegocio.Funciones.mError(this, mozo1.Mensaje);
                    }

                }
                else
                {
                    CapaNegocio.Funciones.mOk(this, "Los datos del mozo se guardaron con éxito.");
                    dgvMozos.DataSource = Mozo.ListarTodos();
                    Clear();
                    pnlMozo.Enabled = false;
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clear();
            pnlMozo.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clear();
            if (RowSeleccionado(dgvMozos.SelectedRows.Count, "eliminarlo."))
            {
                Clear();
                pnlMozo.Enabled = false;
                if (CapaNegocio.Funciones.mConsulta(this, "¿Está seguro de que desea eliminar el mozo?"))
                {
                    long cuil = Convert.ToInt64(dgvMozos.CurrentRow.Cells["cuil"].Value);
                    if (Mozo.Eliminar(cuil))
                    {
                        Funciones.mOk(this, "Se eliminó correctamente el mozo.");
                        dgvMozos.DataSource = Mozo.ListarTodos();
                    }
                    else
                    {
                        Funciones.mError(this, "Error al eliminar el mozo.");
                    }
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Clear();
            if (RowSeleccionado(dgvMozos.SelectedRows.Count, "modificarlo."))
            {
                pnlMozo.Enabled = true;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
                banderaGuardar = false;

                long cuil = Convert.ToInt64(dgvMozos.CurrentRow.Cells["cuil"].Value);
                mozo = CapaNegocio.Mozo.TraerUnMozo(cuil);

                txtApellido.Text = mozo.Apellido;
                txtCuil.Text = mozo.Cuil.ToString();
                txtDireccion.Text = mozo.Direccion;
                txtMail.Text = mozo.Mail;
                txtNombre.Text = mozo.Nombre;
                dtpNacimiento.Value = mozo.Nacimiento;
            }
        }


        //TextBoxs
        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = soloLetras(e.KeyChar);
        }

        private void txtApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = soloLetras(e.KeyChar);
        }

        private void txtMail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = sinEspacios(e.KeyChar);
        }


        //Métodos
        public void Clear()
        {
            txtApellido.Text = "";
            txtCuil.Text = "";
            txtDireccion.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            dtpNacimiento.Value = DateTime.Today;
            pnlMozo.Enabled = false;
        }

        private Boolean soloLetras(char e)
        {
            Boolean result = false;
            if (Char.IsLetter(e))
            {
                result = false;
            }
            else if (Char.IsControl(e))
            {
                result = false;
            }
            else if (Char.IsSeparator(e))
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        private Boolean sinEspacios(char e)
        {


            Boolean result = false;
            if (Char.IsSeparator(e))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        private void MostrarDatosMozo(long cuil)
        {
            Mozo mozo = CapaNegocio.Mozo.TraerUnMozo(cuil);

            txtApellido.Text = mozo.Apellido;
            txtCuil.Text = mozo.Cuil.ToString();
            txtDireccion.Text = mozo.Direccion;
            txtMail.Text = mozo.Mail;
            txtNombre.Text = mozo.Nombre;
            dtpNacimiento.Value = mozo.Nacimiento;
        }

        private void GuardarModificacion()
        {
            mozo.Cuil = Convert.ToInt64(txtCuil.Text.Replace("-", ""));
            mozo.Nombre = txtNombre.Text;
            mozo.Apellido = txtApellido.Text;
            mozo.Direccion = txtDireccion.Text;
            mozo.Mail = txtMail.Text;
            mozo.Nacimiento = dtpNacimiento.Value;

            if (mozo.ModificarMozo())
            {
                CapaNegocio.Funciones.mOk(this, "Los cambios al mozo se guardaron correctamente");
                dgvMozos.DataSource = Mozo.ListarTodos();
                banderaGuardar = true;
                Clear();
                pnlMozo.Enabled = false;
            }
            dgvMozos.DataSource = Mozo.ListarTodos();
        }

        private Boolean RowSeleccionado(int c, string msj) {
            if (c == 1)
            {
                return true;
            }
            else if (c == 0)
            {
                Funciones.mAdvertencia(this, "Debe seleccionar un mozo para poder " + msj);
                return false;
            }
            else
            {
                Funciones.mAdvertencia(this, "Debe seleccionar sólo un mozo.");
                return false;
            }
        }

    }
}

