using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kost
{
    public delegate void volverAComandasActivasEventHandler();

    public delegate void cerrarComandaEventHandler();

    public partial class Comanda : UserControl, Interfaz
    {
        public event volverAComandasActivasEventHandler btnIrAAtrasCLick;

        public event cerrarComandaEventHandler cerrarComanda;

        Boolean banderaGuardar = true;
        Boolean aux = false;
        int nroD;
        public int numeroComanda;

        public Comanda()
        {
            InitializeComponent();
            txtDescuento.Text = "0";
        }

        //Botones
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.btnIrAAtrasCLick();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            pnlDetalle.Enabled = true;
            btnCerrarComanda.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clear();
            btnCerrarComanda.Enabled = false;
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvComanda.SelectedRows.Count, "un detalle", "modificarlo.", this))
            {
                pnlDetalle.Enabled = true;

                banderaGuardar = false;

                nroD = Convert.ToInt32(dgvComanda.CurrentRow.Cells["N_Detalle"].Value);
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
                    int nroD = Convert.ToInt32(dgvComanda.CurrentRow.Cells["N_Detalle"].Value);
                    int codProd = Convert.ToInt32(dgvComanda.CurrentRow.Cells["Codigo_Producto"].Value);
                    int cant = Convert.ToInt32(dgvComanda.CurrentRow.Cells["Cantidad"].Value);
                    if (Detalle.Eliminar(nroD, codProd, cant))
                    {
                        Funciones.mOk(this, "Se eliminó correctamente el detalle.");
                        CargarDGV();
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
                if (txtCantidad.Text.Equals(""))
                {
                    Funciones.mError(this, "Debe indicar la cantidad.");
                }
                else
                {
                    CapaNegocio.Detalle detal = new CapaNegocio.Detalle(numeroComanda, Convert.ToInt32(cbxProducto.SelectedValue), cbxProducto.Text, Convert.ToInt32(txtCantidad.Text), float.Parse(lblPrecioProducto.Text.Replace("$", "")));
                    if (!detal.Error)
                    {
                        CargarDGV();
                        CalcularTotal();
                        Clear();
                        pnlDetalle.Enabled = false;
                        btnCerrarComanda.Enabled = true;
                    }
                    else
                    {
                        CapaNegocio.Funciones.mError(this, detal.Mensaje);
                    }
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

            coman.Total = Convert.ToSingle(lblTotal.Text.Replace("$", ""));
            coman.Descuento = Convert.ToSingle(txtDescuento.Text);
            
            coman.PrecioFinal = (Convert.ToSingle(lblTotal.Text.Replace("$", "")) - (Convert.ToSingle(lblTotal.Text.Replace("$", ""))*(Convert.ToSingle(txtDescuento.Text)/100)));

            lblPrecioFinal.Text = "$"+coman.PrecioFinal;
            btnCerrarComanda.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            coman.CerrarComanda();

            this.cerrarComanda();

            //this.btnIrAAtrasCLick();
        }

        //Funciones
        public void Clear()
        {
            lblPrecioUnitario.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "0";
        }

        private void GuardarModificacion()
        {
            if (CapaNegocio.Detalle.Modificar(nroD, Convert.ToInt32(cbxProducto.SelectedValue), Convert.ToInt32(txtCantidad.Text), Convert.ToSingle(lblPrecioProducto.Text.Replace("$", "")), cbxProducto.Text))
            {
                CapaNegocio.Funciones.mOk(this, "Los cambios al detalle se guardaron correctamente");
                dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(numeroComanda);
                banderaGuardar = true;
                Clear();
                pnlDetalle.Enabled = false;
                btnCerrarComanda.Enabled = true;
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
                total += Convert.ToInt32(row.Cells["precioUni"].Value.ToString()) * Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
            }

            lblTotal.Text = textTotal += total;
        }

        public void setComanda(int nroCom)
        {
            CapaNegocio.Comanda comm = CapaNegocio.Comanda.TraerComanda(nroCom);

            numeroComanda = comm.NroComanda;

            lblNumeroComanda.Text = "N° Comanda: " + comm.NroComanda.ToString();

            lblNumeroMesa.Text = "N° Mesa: " + comm.NroMesa.ToString();

            lblMozo.Text = "Mozo: " +  CapaNegocio.Comanda.NombreMozo(comm.CuilMozo);

            dgvComanda.DataSource = CapaNegocio.Detalle.TraerTodosDetalles(nroCom);

            CalcularTotal();
        }

        public void CargarDGV()
        {
            float subtotal = 0;

            dgvComanda.DataSource = Detalle.TraerTodosDetalles(numeroComanda);

            foreach (DataGridViewRow row in dgvComanda.Rows)
            {
                subtotal += (Convert.ToInt32(row.Cells["precioUni"].Value.ToString()) * Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()));
                row.Cells["Subtotal"].Value = subtotal;
            }
        }

        public void CargarCBX()
        {
            DataTable productos = Producto.TraerNoInsumos();

            cbxProducto.DataSource = productos.DefaultView;
            cbxProducto.ValueMember = "codProd";
            cbxProducto.DisplayMember = "nombre";
            cbxProducto.BindingContext = this.BindingContext;
        }

        public void ActualizarPantalla()
        {
            Clear();

            pnlDetalle.Enabled = false;

            CargarCBX();

            CargarDGV();

            //cbxProducto.SelectedIndex = 0;
            aux = true;

            cbxProducto_SelectedIndexChanged(this, new EventArgs());
            
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                lblPrecioProducto.Text = "$" + Producto.PrecioDeVenta(Convert.ToInt32(cbxProducto.SelectedValue));
            }
            else {
                ActualizarPantalla();
            }           
        }
    }
}
