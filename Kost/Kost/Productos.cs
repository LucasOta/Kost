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
    public delegate void irProductoCompuestoEventHandler();
    public delegate void modificarProductoCompuestoEventHandler(int id);

    public delegate void irProductoSimpleEventHandler();
    public delegate void modificarProductoSimpleEventHandler(int id);

    public delegate void irVerStockEventHandler();


    public partial class Productos : UserControl, Interfaz
    {
        public event irProductoCompuestoEventHandler btnIrCompuesto;
        public event modificarProductoCompuestoEventHandler modificarCompuesto;
        public event irProductoSimpleEventHandler btnIrSimple;
        public event modificarProductoSimpleEventHandler modificarSimple;
        public event irVerStockEventHandler btnIrStocks;

        public Productos()
        {
            InitializeComponent();
        }

        //Botones
        private void btnAgregarCompuesto_Click(object sender, EventArgs e)
        {
            this.btnIrCompuesto();
        }

        private void btnAgregarSimple_Click(object sender, EventArgs e)
        {
            this.btnIrSimple();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvProductos.SelectedRows.Count, "un producto", "modificarlo.", this))
            {
                if (es_Compuesto())
                {
                    this.modificarCompuesto(Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value));
                }
                else {
                    this.modificarSimple(Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value));
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvProductos.SelectedRows.Count, "un producto", "eliminarlo.", this))
            {
                if (CapaNegocio.Funciones.mConsulta(this, "¿Está seguro de que desea eliminar el producto?"))
                {
                    if (Producto.EliminarProd(Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value)))
                    {
                        Funciones.mOk(this, "Producto eliminado con éxito");

                        ActualizarPantalla();
                    }
                    else
                    {
                        Funciones.mError(this, "No se pudo eliminar el producto, intente nuevamente");
                    }
                }
            }
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            this.btnIrStocks();
        }

        //Métodos
        public void Clear()
        {
            
        }

        public void ActualizarPantalla()
        {
            dgvProductos.DataSource = CapaNegocio.Producto.ListarTodos();
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private Boolean es_Compuesto() {
            if ((Convert.ToString(dgvProductos.CurrentRow.Cells["Tipo"].Value)).Equals("Compuesto")) {
                return true;
            }
            return false;
        }               
    }
}
