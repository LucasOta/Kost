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
    public partial class AgregarSimple : UserControl, Interfaz
    {
        public event volverAProductos btnIrAtras;

        public AgregarSimple()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void AgregarSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.btnIrAtras();
        }

        //Métodos
        public void Clear()
        {
            
        }

        public void ActualizarPantalla()
        {
            
        }

        public void cargarProd_a_Modificar(int id) {
            ProdSimple prod = new ProdSimple();
            ProdSimple.TraerUnProducto(id, prod);
            //Cargar el Producto a todos los elementos de la pantalla
        }
                
    }
}
