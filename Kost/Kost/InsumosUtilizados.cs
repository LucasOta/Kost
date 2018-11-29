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
            DataTable productos = Reportes.InsumosUtilizados(dtpInsumosUtilizados.Value);
            productos.Columns.Add("U_Medida");
            productos.Columns.Add("Cantidad");


            foreach (DataRow row in productos.Rows)
            {
                switch (((int)row["unidad"]))
                {
                    case 1:
                        row["U_Medida"] = "Kilos";
                        row["Cantidad"] = (int)row["cantidad"] / 1000;
                        break;
                    case 2:
                        row["U_Medida"] = "Unidades";
                        row["Cantidad"] = row["cantidad"];
                        break;
                    case 3:
                        row["U_Medida"] = "Litros";
                        row["Cantidad"] = (int)row["cantidad"] / 1000;
                        break;
                    default:
                        break;
                }
            }
            productos.Columns.Remove("unidad");

            dgvInsumosUtilizados.DataSource = productos;
            dgvInsumosUtilizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void ActualizarPantalla()
        {
            Clear();

            CargarDGV();
        }
    }
}
