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
    public delegate void irAComandaEventHandler(int nroComanda);

    public partial class ComandasActivas : UserControl
    {
        public event irAComandaEventHandler btnIrAComandaCLick;

        Boolean banderaGuardar = true;
        int ComandaMod;

        public ComandasActivas()
        {
            InitializeComponent();

            CargarDGV();

            int cont;

            DataTable mesas = new DataTable();

            mesas.Clear();
            mesas.Columns.Add("nroMesa");

            DataRow row;

            for (cont = 1; cont < 16; cont++)
            {
                row = mesas.NewRow();
                row["nroMesa"] = cont.ToString();
                mesas.Rows.Add(row);
            }

            cbxMesa.DataSource = mesas.DefaultView;
            cbxMesa.ValueMember = "nroMesa";
            cbxMesa.DisplayMember = "nroMesa";
            cbxMesa.BindingContext = this.BindingContext;

            DataTable mozos = CapaNegocio.Mozo.ListarTodos();

            cbxMozo.DataSource = mozos.DefaultView;
            cbxMozo.ValueMember = "cuil";
            cbxMozo.DisplayMember = "nya";
            cbxMozo.BindingContext = this.BindingContext;

            pnlComanda.Enabled = false;
            dgvComandasActivas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Clear()
        {
            cbxMesa.SelectedValue = 1;
        }

        private void GuardarModificacion()
        {
            if (CapaNegocio.Comanda.ModificarComanda(Convert.ToInt32(cbxMesa.SelectedValue), Convert.ToInt64(cbxMozo.SelectedValue), ComandaMod))
            {
                CapaNegocio.Funciones.mOk(this, "Los cambios a la comanda se guardaron correctamente");
                dgvComandasActivas.DataSource = CapaNegocio.Comanda.ComandasActivas();
                banderaGuardar = true;
                Clear();
                pnlComanda.Enabled = false;
            }
            else
            {
                CapaNegocio.Funciones.mError(this, "El numero de mesa elegido ya esta siendo usado en una comanda activa");
            }
        }

        public void CargarDGV()
        {
            dgvComandasActivas.DataSource = CapaNegocio.Comanda.ComandasActivas();
        }


        //Botones
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            pnlComanda.Enabled = true;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Clear();
            pnlComanda.Enabled = true;
            banderaGuardar = false;

            ComandaMod = Convert.ToInt32(dgvComandasActivas.CurrentRow.Cells["N_Comanda"].Value);
            CapaNegocio.Comanda comm = CapaNegocio.Comanda.TraerComanda(ComandaMod);

            cbxMesa.SelectedValue = comm.NroMesa;
            cbxMozo.SelectedValue = comm.CuilMozo;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Clear();

            pnlComanda.Enabled = false;
        }

        private void btnIrAComanda_Click_1(object sender, EventArgs e)
        {
            int nroCom = Convert.ToInt32(dgvComandasActivas.CurrentRow.Cells["N_Comanda"].Value);

            this.btnIrAComandaCLick(nroCom);
        }
    }
}
