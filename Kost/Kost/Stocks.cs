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
    public delegate void volverAProductos();

    public partial class Stocks : UserControl, Interfaz
    {
        public event volverAProductos btnIrAtras;

        ProdSimple PS = new ProdSimple();

        public Stocks()
        {
            InitializeComponent();
        }

        //Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {           
            PS.Stock = PS.Stock + Convert.ToInt32(txtAgregar.Text);            
            
            PS.Stock = PS.Stock - Convert.ToInt32(txtQuitar.Text);

            ActualizarPantalla();

            pnlProducto.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (CapaNegocio.Funciones.RowSeleccionado(dgvProductos.SelectedRows.Count, "un producto", "modificar el stock.", this))
            {
                pnlProducto.Enabled = true;

            CapaNegocio.ProdSimple.TraerUnSimple(Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value), PS);
            
            lblNombre.Text = PS.Nombre;
            lblDescripcion.Text = PS.DescProd;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();

            pnlProducto.Enabled = false;
        }
        //Métodos
        public void Clear()
        {
            lblNombre.Text = "(Nombre del Producto)";
            lblDescripcion.Text = "(Descripción del Producto)";
            txtAgregar.Text = "";
            txtQuitar.Text = "";
        }

        public void ActualizarPantalla()
        {
            Clear();

            dgvProductos.DataSource = CapaNegocio.ProdSimple.MostrarStock();

            pnlProducto.Enabled = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.btnIrAtras();
        }


    }
}
