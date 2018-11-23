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

    public partial class ComandasActivas : UserControl, Interfaz
    {
        public event irAComandaEventHandler btnIrAComandaCLick;

        Boolean banderaGuardar = true;
        int ComandaMod;
        CapaNegocio.Comanda comm;

        public ComandasActivas()
        {
            InitializeComponent();

            ActualizarPantalla();
        }



        //Botones
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Clear();
            pnlComanda.Enabled = true;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {           
            Clear();
            if (CapaNegocio.Funciones.RowSeleccionado(dgvComandasActivas.SelectedRows.Count, "una comanda", "modificarla.", this))
            {
                pnlComanda.Enabled = true;
                banderaGuardar = false;

                ComandaMod = Convert.ToInt32(dgvComandasActivas.CurrentRow.Cells["N_Comanda"].Value);
                comm = CapaNegocio.Comanda.TraerComanda(ComandaMod);

                cbxMesa.SelectedValue = comm.NroMesa;
                cbxMozo.SelectedValue = comm.CuilMozo;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            
            if (CapaNegocio.Funciones.RowSeleccionado(dgvComandasActivas.SelectedRows.Count, "una comanda", "eliminarla.", this))
            {                
                if (CapaNegocio.Funciones.mConsulta(this, "¿Esta seguro de que desea eliminar la comanda?"))
                {
                    int nroC = Convert.ToInt32(dgvComandasActivas.CurrentRow.Cells["N_Comanda"].Value);
                    if (CapaNegocio.Comanda.Eliminar(nroC))
                    {
                        Funciones.mOk(this, "Se eliminó correctamente la comanda.");
                        dgvComandasActivas.DataSource = CapaNegocio.Comanda.ComandasActivas();
                    }
                    else
                    {
                        Funciones.mError(this, "Error al eliminar la comanda.");
                    }
                    Clear();
                    pnlComanda.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                CapaNegocio.Comanda comm = new CapaNegocio.Comanda(Convert.ToInt32(cbxMesa.SelectedValue), Convert.ToInt64(cbxMozo.SelectedValue), DateTime.Now);
                if (!comm.Error)
                {
                    CapaNegocio.Funciones.mOk(this, "Se guardo la comanda exitosamente");
                    dgvComandasActivas.DataSource = CapaNegocio.Comanda.ComandasActivas();
                    Clear();
                    pnlComanda.Enabled = false;
                }
                else
                {
                    CapaNegocio.Funciones.mError(this, comm.Mensaje);
                }
            }
            else
            {
                GuardarModificacion();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Clear();

            pnlComanda.Enabled = false;
        }

        private void btnIrAComanda_Click_1(object sender, EventArgs e)
        {
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvComandasActivas.SelectedRows.Count, "una comanda", "ver los detalles de la misma.", this))
            {
                this.btnIrAComandaCLick(Convert.ToInt32(dgvComandasActivas.CurrentRow.Cells["N_Comanda"].Value));
            }
        }


        //Métodos
        public void Clear()
        {
            cbxMesa.SelectedValue = 1;
            cbxMozo.SelectedValue = 1;
        }

        private void GuardarModificacion()
        {
            comm.NroMesa = Convert.ToInt32(cbxMesa.SelectedValue);
            comm.CuilMozo = Convert.ToInt64(cbxMozo.SelectedValue);
            comm.NroComanda = ComandaMod;

            if (comm.ModificarComanda())
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

        public void CargarCBX()
        {
            //Harcodeo cantidad de mesas
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
        }

        public void ActualizarPantalla()
        {
            CargarDGV();

            CargarCBX();

            pnlComanda.Enabled = false;
            dgvComandasActivas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
