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
    public delegate void volverAComandasActivasEventHandler();

    public delegate void cerrarComandaEventHandler();

    public partial class Comanda : UserControl, Interfaz
    {
        public event volverAComandasActivasEventHandler btnIrAAtrasCLick;

        public event cerrarComandaEventHandler cerrarComanda;

        Boolean banderaGuardar = true;

        public int numeroComanda;

        public Comanda()
        {
            InitializeComponent();

            ActualizarPantalla();
        }

        //Botones
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.btnIrAAtrasCLick();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            pnlDetalle.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clear();

            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvComanda.SelectedRows.Count, "un detalle", "modificarlo.", this))
            {
                pnlDetalle.Enabled = true;

                banderaGuardar = false;

                int nroD = Convert.ToInt32(dgvComanda.CurrentRow.Cells["nroDetalle"].Value);
                Detalle detal = CapaNegocio.Detalle.TraerUnDetalle(nroD);

                cbxProducto.SelectedValue = detal.CodProducto;
                txtCantidad.Text = detal.Cantidad.ToString();
                lblPrecioUnitario.Text = detal.PrecioUnitario.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlDetalle.Enabled = false;

            Clear();

            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvComanda.SelectedRows.Count, "un detalle", "eliminarlo.", this))
            {
                if (CapaNegocio.Funciones.mConsulta(this, "¿Está seguro de que desea eliminar el detalle?"))
                {
                    int nroD = Convert.ToInt32(dgvComanda.CurrentRow.Cells["nroDetalle"].Value);
                    if (Detalle.Eliminar(nroD))
                    {
                        Funciones.mOk(this, "Se eliminó correctamente el detalle.");
                        dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(numeroComanda);
                        CalcularTotal();
                    }
                    else
                    {
                        Funciones.mError(this, "Error al eliminar el detalle.");
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                CapaNegocio.Detalle detal = new CapaNegocio.Detalle(numeroComanda, Convert.ToInt32(cbxProducto.SelectedValue), cbxProducto.SelectedText, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(lbl1.Text.Replace("Precio unit.        ", "")));
                if (!detal.Error)
                {
                    CapaNegocio.Funciones.mOk(this, "Se guardo el detalle exitosamente");
                    dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(numeroComanda);
                    CalcularTotal();
                    Clear();
                    pnlDetalle.Enabled = false;
                }
                else
                {
                    CapaNegocio.Funciones.mError(this, detal.Mensaje);
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

            pnlDetalle.Enabled = false;
        }

        private void btnCerrarComanda_Click(object sender, EventArgs e)
        {
            CapaNegocio.Comanda coman = CapaNegocio.Comanda.TraerComanda(numeroComanda);

            coman.Total = (Convert.ToSingle(txtDescuento.Text) + Convert.ToSingle(lblTotal.Text.Replace("$", "")));
            coman.Descuento = Convert.ToSingle(txtDescuento.Text);
            coman.PrecioFinal = Convert.ToSingle(lblTotal.Text.Replace("$", ""));

            coman.CerrarComanda();

            this.cerrarComanda();

            this.btnIrAAtrasCLick();
        }

        //Funciones
        public void Clear()
        {
            lblPrecioUnitario.Text = "";
            txtCantidad.Text = "";
            cbxProducto.SelectedValue = 1;
        }

        private void GuardarModificacion()
        {
            if (CapaNegocio.Detalle.Modificar(Convert.ToInt32(cbxProducto.SelectedValue), Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(lbl1.Text.Replace("Precio unit.        ", "")), cbxProducto.SelectedText))
            {
                CapaNegocio.Funciones.mOk(this, "Los cambios al detalle se guardaron correctamente");
                dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(numeroComanda);
                banderaGuardar = true;
                Clear();
                pnlDetalle.Enabled = false;
            }
            else
            {
                Funciones.mError(this, "Error al modificar la comanda.");
            }
            dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(numeroComanda);
        }

        private void CalcularTotal()
        {
            float total = 0;

            string textTotal = "$";

            foreach (DataGridViewRow row in dgvComanda.Rows)
            {
                total += Convert.ToInt32(row.Cells["Precio"].Value.ToString());
            }

            lblTotal.Text = textTotal += total;
        }

        public void setComanda(int nroCom)
        {
            CapaNegocio.Comanda comm = CapaNegocio.Comanda.TraerComanda(nroCom);

            lblNumeroComanda.Text = "N° Comanda: " + comm.NroComanda.ToString();

            lblNumeroMesa.Text = "N° Mesa: " + comm.NroMesa.ToString();

            lblMozo.Text = "Mozo: " +  CapaNegocio.Comanda.NombreMozo(comm.CuilMozo);

            dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(nroCom);

            CalcularTotal();
        }

        public void CargarCBX()
        {
            DataTable productos = Producto.TraerNoInsumos();

            //cbxProducto.DataSource = productos.DefaultView;
            cbxProducto.ValueMember = "codProd";
            cbxProducto.DisplayMember = "nombre";
            cbxProducto.BindingContext = this.BindingContext;
        }

        public void ActualizarPantalla()
        {
            pnlDetalle.Enabled = false;

            CargarCBX();
        }
    }
}
