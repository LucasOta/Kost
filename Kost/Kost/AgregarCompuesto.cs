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
    public partial class AgregarCompuesto : UserControl, Interfaz
    {
        public event volverAProductos btnIrAtras;

        Boolean banderaGuardar = true;
        Boolean aux = false;
        ProdCompuesto pc;

        public AgregarCompuesto()
        {
            InitializeComponent();
        }

        private void lblComponentes_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            Clear();
            this.btnIrAtras();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {

            }
            else
            {
                GuardarModificacion();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            btnAtras_Click_1(this, new EventArgs());
        }


        //Métodos
        public void Clear()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            dgvComponentes.DataSource = null;
        }

        public void ActualizarPantalla()
        {
            Clear();

            CargarCBXCategoria();
            CargarCBXComponentes();

            aux = true;
        }

        public void CargarCBXCategoria()
        {
            DataTable productos = CapaNegocio.Categoria.ListarTodos();

            cbxCategoria.DataSource = productos.DefaultView;
            cbxCategoria.ValueMember = "idCategoria";
            cbxCategoria.DisplayMember = "nombre";
            cbxCategoria.BindingContext = this.BindingContext;
        }

        public void CargarCBXComponentes()
        {
            DataTable productos = CapaNegocio.ProdSimple.TraerInsumos();

            cbxComponente.DataSource = productos.DefaultView;
            cbxComponente.ValueMember = "codProdSimple";
            cbxComponente.DisplayMember = "nombre";
            cbxComponente.BindingContext = this.BindingContext;
        }

        public void CargarDGV()
        {
            dgvComponentes.DataSource = ProdCompuesto.TraerComposicion(pc.CodProdCompuesto);
            dgvComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void cargarProd_a_Modificar(int id)
        {
            ActualizarPantalla();

            pc = new CapaNegocio.ProdCompuesto();
            ProdCompuesto.TraerUnProducto(id, pc);

            pc.CodProdCompuesto = id;
            txtNombre.Text = pc.Nombre;
            txtDescripcion.Text = pc.DescProd;
            cbxCategoria.SelectedValue = pc.IdCategoria;
            txtPrecio.Text = pc.PrecioVenta.ToString();
            CargarDGV();

            banderaGuardar = false;
        }

        private void cbxComponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                CargarCBXComponentes();
            }
            else
            {
                ActualizarPantalla();
            }
        }

        public void GuardarModificacion()
        {

        }        
    }
}
