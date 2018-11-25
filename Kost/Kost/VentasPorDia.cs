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
    public partial class VentasPorDia : UserControl, Interfaz
    {
        public VentasPorDia()
        {
            InitializeComponent();
        }

        private void dtpVentasDiarias_ValueChanged(object sender, EventArgs e)
        {
            CargarDGV();
        }

        //Métodos
        public void Clear()
        {
            dtpVentasDiarias.Value = DateTime.Now;
        }

        public void CargarDGV()
        {
            dgvVentasDiarias.DataSource = Reportes.VentasPorDia(dtpVentasDiarias.Value);
        }

        public void ActualizarPantalla()
        {
            Clear();

            CargarDGV();
        }
    }
}
