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
        Boolean banderaGuardar = true;
        CapaNegocio.Categoria cat;

        public Categoria()
        {
            InitializeComponent();            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlCategoria.Enabled = true;
            txtNombre.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            pnlCategoria.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                CapaNegocio.Categoria categ = new CapaNegocio.Categoria(txtNombre.Text);
                if (categ.Error)
                {
                    CapaNegocio.Funciones.mError(this, categ.Mensaje);
                }
                else
                {
                    CapaNegocio.Funciones.mOk(this, "Los datos de la categoría se guardaron con éxito.");
                    dgvCategorias.DataSource = CapaNegocio.Categoria.ListarTodos();
                    txtNombre.Clear();
                    pnlCategoria.Enabled = false;
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

            int idCat = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["ID"].Value);
            cat = CapaNegocio.Categoria.TraerUnaCat(idCat);

            txtNombre.Text = cat.Nombre;
        }

        //Métodos

        private void GuardarModificacion()
        {
            cat.Nombre = txtNombre.Text;
            cat.Id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["ID"].Value);

            if (cat.ModificarCateg())
            {
                CapaNegocio.Funciones.mOk(this, "Los cambios se guardaron correctamente");
                banderaGuardar = true;
                txtNombre.Clear();
                pnlCategoria.Enabled = false;
            }
            dgvCategorias.DataSource = CapaNegocio.Categoria.ListarTodos();
        }

        public void Clear()
        {
            txtNombre.Text = "";
            pnlCategoria.Enabled = false;
        }

        public void ActualizarPantalla()
        {
            dgvCategorias.DataSource = CapaNegocio.Categoria.ListarTodos();
            pnlCategoria.Enabled = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
