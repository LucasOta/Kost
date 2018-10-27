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

    public partial class Comanda : UserControl
    {
        public event volverAComandasActivasEventHandler btnIrAAtrasCLick;

        public event cerrarComandaEventHandler cerrarComanda;

        Boolean banderaGuardar = true;

        public int numeroComanda;

        public Comanda()
        {
            InitializeComponent();

            pnlDetalle.Enabled = false;
        }

        //Botones
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.btnIrAAtrasCLick();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDetalle.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clear();

            string preciounitario = "Precio unit.        ";

            pnlDetalle.Enabled = true;

            banderaGuardar = false;

            int nroD = Convert.ToInt32(dgvComanda.CurrentRow.Cells["nroDetalle"].Value);
            Detalle detal = CapaNegocio.Detalle.TraerUnDetalle(nroD);

            cbxProducto.SelectedValue = detal.CodProducto;
            txtCantidad.Text = detal.Cantidad.ToString();
            lblPrecioUnitario.Text = preciounitario += detal.PrecioUnitario.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlDetalle.Enabled = false;

            Clear();

            if (CapaNegocio.Funciones.mConsulta(this, "¿Esta seguro de que desea eliminar el detalle?"))
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                CapaNegocio.Detalle detal = new CapaNegocio.Detalle(numeroComanda, Convert.ToInt32(cbxProducto.SelectedValue), cbxProducto.SelectedText, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(lblPrecioUnitario.Text.Replace("Precio unit.        ", "")));
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
        private void Clear()
        {
            lblPrecioUnitario.Text = "Precio unit.        .........";
            txtCantidad.Text = "";
        }

        private void GuardarModificacion()
        {
            if (CapaNegocio.Detalle.Modificar(Convert.ToInt32(cbxProducto.SelectedValue), Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(lblPrecioUnitario.Text.Replace("Precio unit.        ", "")), cbxProducto.SelectedText))
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
            numeroComanda = nroCom;

            string txtNroCom = "N° Comanda: ";

            string txtNroMesa = "N° Mesa: ";

            string txtMozo = "Mozo: ";

            CapaNegocio.Comanda comm = CapaNegocio.Comanda.TraerComanda(numeroComanda);

            lblNumeroComanda.Text = txtNroCom += comm.NroComanda.ToString();

            lblNumeroMesa.Text = txtNroMesa += comm.NroMesa.ToString();

            lblMozo.Text = txtMozo += CapaNegocio.Comanda.NombreMozo(comm.CuilMozo);

            dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(numeroComanda);

            CalcularTotal();
        }
    }
}
