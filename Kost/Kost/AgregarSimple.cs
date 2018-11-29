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
        }


        //Botones
        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            Clear();
            this.btnIrAtras();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                ps = new CapaNegocio.ProdSimple(0, chxInsumo.Checked,  txtNombre.Text, float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(cbxCategoria.SelectedValue), txtDescripcion.Text, false, Convert.ToInt32(cbxU_Medida.SelectedValue), Convert.ToDouble(txtContenido.Text));
                
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
                GuardarModificacion();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            banderaGuardar = true;
            btnAtras_Click_1(this, new EventArgs());
        }

        //Métodos
        public void Clear()
        {
            ps = new ProdSimple();

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
            ActualizarPantalla();

            ps = new ProdSimple();
            ProdSimple.TraerUnSimple(id, ps);

            txtNombre.Text = ps.Nombre;
            txtDescripcion.Text = ps.DescProd;
            cbxCategoria.SelectedValue = ps.IdCategoria;
            cbxU_Medida.SelectedValue = ps.Unidad;
            txtContenido.Text = ps.Contenido.ToString();
            txtPrecio.Text = ps.PrecioVenta.ToString();
            cbxU_Medida.SelectedValue = ps.Unidad;
            chxInsumo.Checked = ps.Insumo;

            banderaGuardar = false;
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
            DataTable categorias;
            categorias = CapaNegocio.Unidad.ListarTodos();

            cbxU_Medida.DataSource = categorias.DefaultView;
            cbxU_Medida.ValueMember = "idUnidad";
            cbxU_Medida.DisplayMember = "unidad";
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

        private void GuardarModificacion()
        {
            ps.Nombre = txtNombre.Text;
            ps.PrecioVenta = float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture.NumberFormat);
            ps.Insumo = chxInsumo.Checked;
            ps.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
            ps.DescProd = txtDescripcion.Text;
            ps.Contenido = Convert.ToDouble(txtContenido.Text);
            ps.Unidad = Convert.ToInt32(cbxU_Medida.SelectedValue);

            if (ps.ModificarPS())
            {
                CapaNegocio.Funciones.mOk(this, ps.Mensaje);

                Clear();

                btnAtras_Click_1(this, new EventArgs());

                banderaGuardar = true;
            }
            else
            {
                CapaNegocio.Funciones.mError(this, ps.Mensaje);
            }
        }
    }
}
