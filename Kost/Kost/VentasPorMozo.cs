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
    public partial class VentasPorMozo : UserControl, Interfaz
    {
        Boolean aux = false;
        public VentasPorMozo()
        {
            InitializeComponent();
        }

        private void dtpVentasMozo_ValueChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                CargarDGV();
            }
            else
            {
                ActualizarPantalla();
            }            
        }

        private void cbxMozo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aux)
            {
                CargarDGV();
            }
            else
            {
                ActualizarPantalla();
            }      
        }

        //Métodos
        public void Clear()
        {
            dtpVentasMozo.Value = DateTime.Now;
        }

        public void CargarCBX()
        {
            DataTable mozos = Mozo.ListarTodos();

            cbxMozo.DataSource = mozos.DefaultView;
            cbxMozo.ValueMember = "cuil";
            cbxMozo.DisplayMember = "nya";
            cbxMozo.BindingContext = this.BindingContext;
        }

        public void CargarDGV()
        {
            dgvVentasPorMozo.DataSource = Reportes.VentasPorMozo(dtpVentasMozo.Value, Convert.ToInt64(cbxMozo.SelectedValue.ToString()));

            float total = 0;

            foreach (DataGridViewRow row in dgvVentasPorMozo.Rows)
            {
                total += Convert.ToSingle(row.Cells["Total"].Value.ToString());
            }

            lblTotal.Text = "Total que vendió: $" + total;
        }

        public void ActualizarPantalla()
        {
            Clear();

            CargarCBX();

            CargarDGV();

            aux = true;

            cbxMozo_SelectedIndexChanged(this, new EventArgs());
        }
    }
}
