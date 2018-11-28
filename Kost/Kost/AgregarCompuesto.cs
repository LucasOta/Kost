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
using System.Globalization;

namespace Kost
{
    public partial class AgregarCompuesto : UserControl, Interfaz
    {
        public event volverAProductos btnIrAtras;
                
        Boolean banderaGuardar = true;
        Boolean aux = false;
        ProdCompuesto pc;
        DataTable composicion = new DataTable();

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
                pc = new ProdCompuesto(txtNombre.Text, float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(cbxCategoria.SelectedValue), txtDescripcion.Text, true, composicion);

                if (pc.Error)
                {
                    CapaNegocio.Funciones.mError(this, pc.Mensaje);
                }
                else
                {
                    CapaNegocio.Funciones.mOk(this, pc.Mensaje);

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
            btnAtras_Click_1(this, new EventArgs());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                DataRow row;

                row = composicion.NewRow();
                row["codProdSim"] = cbxComponente.SelectedValue;
                row["nombre"] = cbxComponente.Text;
                if ((txtCantidad.Text).Equals(""))
                {
                    row["cantidad"] = 1;
                }
                else
                {
                    row["cantidad"] = txtCantidad.Text;
                }
                composicion.Rows.Add(row);

                CargarDGV(composicion);

                txtCantidad.Text = "";
                cbxComponente.SelectedIndex = 0;
            }
            else
            {
                int cantidad;
                if ((txtCantidad.Text).Equals(""))
                {
                    cantidad = 1;
                }
                else
                {
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                }

                if (ProdCompuesto.GuardarComposicionMod(pc.CodProdCompuesto, Convert.ToInt32(cbxComponente.SelectedValue), cantidad))
                {
                    CargarDGV(ProdCompuesto.TraerComposicion(pc.CodProdCompuesto));
                }
                else
                {
                    CapaNegocio.Funciones.mError(this, "No se pudo guardar el componente debido a un error de conexión con BD.");
                }
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                composicion.Rows[dgvComponentes.CurrentRow.Index].Delete();
            }
            else
            {
                if(ProdCompuesto.EliminarComposicion(pc.CodProdCompuesto, Convert.ToInt32(dgvComponentes.CurrentRow.Cells["CodProd"].Value), Convert.ToInt32(dgvComponentes.CurrentRow.Cells["Cantidad"].Value)))
                {
                    CapaNegocio.Funciones.mOk(this, "Se elimino correctamente el componente del producto");

                    CargarDGV(ProdCompuesto.TraerComposicion(pc.CodProdCompuesto));
                }
                else
                {
                    CapaNegocio.Funciones.mError(this, "No se pudo eliminar el componente debido a un error de conexión con BD.");
                }
            }
        }

        //Métodos
        public void Clear()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            composicion.Clear();
        }

        public void ActualizarPantalla()
        {
            Clear();

            CargarCBXCategoria();
            CargarCBXComponentes();

            if (!aux)
            {
                composicion.Clear();
                composicion.Columns.Add("codProdSim");
                composicion.Columns.Add("nombre");
                composicion.Columns.Add("cantidad");
            }

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

        public void CargarDGV(DataTable carga)
        {
            dgvComponentes.DataSource = carga;
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
            CargarDGV(ProdCompuesto.TraerComposicion(pc.CodProdCompuesto));

            banderaGuardar = false;
        }

        public void GuardarModificacion()
        {
            pc.Nombre = txtNombre.Text;
            pc.PrecioVenta = float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture.NumberFormat);
            pc.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
            pc.DescProd = txtDescripcion.Text;
            pc.Compuesto = true;

            if (pc.ModificarProducto())
            {
                CapaNegocio.Funciones.mOk(this, pc.Mensaje);

                Clear();

                btnAtras_Click_1(this, new EventArgs());

                banderaGuardar = true;
            }
            else
            {
                CapaNegocio.Funciones.mError(this, pc.Mensaje);
            }
        }                
    }
}
