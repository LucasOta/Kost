using System;
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
    public partial class Categoria : UserControl, Interfaz
    {
        public event volverAProductos btnIrAtras;

        Boolean banderaGuardar = true;
        CapaNegocio.Categoria cat;
        int idCat_a_Modificar;

        public Categoria()
        {
            InitializeComponent();
            pnlCategoria.Enabled = false;          
        }


        //Botones
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            pnlCategoria.Enabled = true;
            txtNombre.Clear();
            banderaGuardar = true;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                CapaNegocio.Categoria categ = new CapaNegocio.Categoria(txtNombre.Text, !chbActiva.Checked);

                if (categ.Error)
                {
                    CapaNegocio.Funciones.mError(this, categ.Mensaje);
                }
                else
                {
                    CapaNegocio.Funciones.mOk(this, "Los datos de la categoría se guardaron con éxito.");
                    ActualizarPantalla();
                }
            }
            else
            {
                GuardarModificacion();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clear();
            pnlCategoria.Enabled = true;
            banderaGuardar = false;

            idCat_a_Modificar = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["ID"].Value);
            cat = CapaNegocio.Categoria.TraerUnaCat(idCat_a_Modificar);

            txtNombre.Text = cat.Nombre;
            chbActiva.Checked = !cat.Baja;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.btnIrAtras();
        }


        //Métodos
        private void GuardarModificacion()
        {
            cat.Nombre = txtNombre.Text;
            cat.Id = idCat_a_Modificar;
            cat.Baja = !chbActiva.Checked;

            if (cat.ModificarCateg())
            {
                CapaNegocio.Funciones.mOk(this, "Los cambios se guardaron correctamente");
                banderaGuardar = true;
                txtNombre.Clear();
                pnlCategoria.Enabled = false;
            }
            else {
                CapaNegocio.Funciones.mError(this, cat.Mensaje);
            }
            ActualizarPantalla();
        }

        public void Clear()
        {
            txtNombre.Text = "";
            pnlCategoria.Enabled = false;
        }

        public void ActualizarPantalla()
        {
            dgvCategorias.DataSource = CapaNegocio.Categoria.ListarAbsolutamenteTodos();
            pnlCategoria.Enabled = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
