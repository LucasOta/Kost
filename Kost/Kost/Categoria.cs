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
    public partial class Categoria : UserControl
    {
        Boolean banderaGuardar = true;
        public Categoria()
        {
            InitializeComponent();

            dgvCategorias.DataSource = CapaNegocio.Categoria.ListarTodos();
            pnlCategoria.Enabled = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        //Métodos

        private void GuardarModificacion()
        {
            if (CapaNegocio.Categoria.ModificarCateg(Convert.ToInt32(dgvCategorias.CurrentRow.Cells["ID"].Value), txtNombre.Text))
            {
                CapaNegocio.Funciones.mOk(this, "Los cambios se guardaron correctamente");
                banderaGuardar = true;
                txtNombre.Clear();
                pnlCategoria.Enabled = false;
            }
            dgvCategorias.DataSource = CapaNegocio.Categoria.ListarTodos();
        }
    }
}
