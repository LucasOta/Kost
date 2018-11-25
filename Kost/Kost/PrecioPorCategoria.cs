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
    public partial class PrecioPorCategoria : UserControl, Interfaz
    {
        Boolean aux = false;
        public PrecioPorCategoria()
        {
            InitializeComponent();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                CargarDGV();
            }
            else
            {
                ActualizarPantalla();
            }            
        }

        //Métodos
        public void Clear()
        {
        }

        public void CargarCBX()
        {
            DataTable productos = CapaNegocio.Categoria.ListarTodos();

            cbxCategoria.DataSource = productos.DefaultView;
            cbxCategoria.ValueMember = "idCategoria";
            cbxCategoria.DisplayMember = "nombre";
            cbxCategoria.BindingContext = this.BindingContext;
        }

        public void CargarDGV()
        {
            dgvPrecioPorCategoria.DataSource = Reportes.PreciosPorCategoria(Convert.ToInt32(cbxCategoria.SelectedValue));
        }

        public void ActualizarPantalla()
        {
            Clear();

            CargarCBX();

            CargarDGV();

            aux = true;

            cbxCategoria_SelectedIndexChanged(this, new EventArgs());
        }        
    }
}
