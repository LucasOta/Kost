using System;
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
    public delegate void irProductoCompuestoEventHandler();

    public delegate void irProductoSimpleEventHandler();

    public partial class Productos : UserControl, Interfaz
    {
        public event irProductoCompuestoEventHandler btnIrCompuesto;

        public event irProductoSimpleEventHandler btnIrSimple;

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
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CapaNegocio.Funciones.RowSeleccionado(
                dgvProductos.SelectedRows.Count, "un producto", "eliminarlo.", this))
            {
                if (CapaNegocio.Funciones.mConsulta(this, "¿Está seguro de que desea eliminar el producto?"))
                {
                }
            }

        }
           
        //Métodos
        public void Clear()
        {
            
        }

        public void ActualizarPantalla()
        {

        }
    }
}
