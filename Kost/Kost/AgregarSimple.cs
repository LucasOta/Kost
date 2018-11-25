using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using System.Globalization;

namespace Kost
{
    public partial class AgregarSimple : UserControl, Interfaz
    {
        public event volverAProductos btnIrAtras;

        Boolean banderaGuardar = true;
        ProdSimple ps;

        //Constructor
        public AgregarSimple()
        {
            InitializeComponent();
            ActualizarPantalla();
        }


        //Clicks
        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.btnIrAtras();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                ps = new CapaNegocio.ProdSimple(0, chxInsumo.Checked,  txtNombre.Text, float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(cbxCategoria.SelectedValue), txtDescripcion.Text, false, 1, Convert.ToDouble(txtContenido.Text));
                
                if (ps.Error)
                {
                    CapaNegocio.Funciones.mError(this, ps.Mensaje);            
                }
                else
                {
                    CapaNegocio.Funciones.mOk(this, ps.Mensaje);

                    Clear();

                    btnAtras_Click_1(this, new EventArgs());
                }
            }
            else
            {
                //GuardarModificacion();
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

            cbxCategoria.SelectedIndex = 0;
            cbxU_Medida.SelectedIndex = 0;

            txtContenido.Text = "";
            txtPrecio.Text = "";

            chxInsumo.Checked = false;
        }

        public void ActualizarPantalla()
        {            
            CargarCBX_Categoria();
            CargarCBX_Unidades();
            Clear();
        }

        public void cargarProd_a_Modificar(int id) {
            ProdSimple prod = new ProdSimple();
            ProdSimple.TraerUnProducto(id, prod);
            //Cargar el Producto a todos los elementos de la pantalla
        }

        public void CargarCBX_Categoria()
        {
            DataTable categorias;
            categorias = CapaNegocio.Categoria.ListarTodos();

            cbxCategoria.DataSource = categorias.DefaultView;
            cbxCategoria.ValueMember = "idCategoria";
            cbxCategoria.DisplayMember = "nombre";
            cbxCategoria.BindingContext = this.BindingContext;
        }

        public void CargarCBX_Unidades()
        {
            //Harcodeo de Unidades
            DataTable unidades = new DataTable();

            unidades.Clear();
            unidades.Columns.Add("U_Medida");

            DataRow row;
            
            row = unidades.NewRow();
            row["U_Medida"] = "Unidad";
            unidades.Rows.Add(row);

            row = unidades.NewRow();
            row["U_Medida"] = "Gramos";
            unidades.Rows.Add(row);

            row = unidades.NewRow();
            row["U_Medida"] = "Mililitros";
            unidades.Rows.Add(row);


            cbxU_Medida.DataSource = unidades.DefaultView;
            cbxU_Medida.ValueMember = "U_Medida";
            cbxU_Medida.DisplayMember = "U_Medida";
            cbxU_Medida.BindingContext = this.BindingContext;
        }

        private void txtContenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapaNegocio.Funciones.acepta_Float(txtContenido.Text, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapaNegocio.Funciones.acepta_Float(txtPrecio.Text, e);
        }        
    }

}
