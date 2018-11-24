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
    public partial class InsumosUtilizados : UserControl, Interfaz
    {
        public InsumosUtilizados()
        {
            InitializeComponent();
        }

        private void dtpInsumosUtilizados_ValueChanged(object sender, EventArgs e)
        {
            CargarDGV();
        }

        //Métodos
        public void Clear()
        {
            dtpInsumosUtilizados.Value = DateTime.Now;
        }

        public void CargarDGV()
        {
            dgvInsumosUtilizados.DataSource = Reportes.InsumosUtilizados(dtpInsumosUtilizados.Value);
        }

        public void ActualizarPantalla()
        {
            Clear();

            CargarDGV();
        }
    }
}
