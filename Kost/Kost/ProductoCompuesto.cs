﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kost
{
    public partial class ProductoCompuesto : UserControl
    {
        public ProductoCompuesto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvComponentes.SelectedRows.Count, "un insumo de la lista", "eliminarlo.", this))
            {
                
            }
        }

    }
}
