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

        public AgregarCompuesto()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void lblComponentes_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.btnIrAtras();
        }


        //Métodos
        public void Clear()
        {
            
        }

        public void ActualizarPantalla()
        {
            CargarCBXCategoria();
            CargarCBXComponentes();
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

        public void cargarProd_a_Modificar(int id)
        {
            //Cambiar lo de abajo a producto compuesto
           // ProdSimple prod = new ProdSimple();
            // ProdSimple.TraerUnProducto(id, prod);
            //Cargar el Producto a todos los elementos de la pantalla
        }

    }
}
