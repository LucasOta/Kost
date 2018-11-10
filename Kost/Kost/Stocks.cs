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
    public delegate void volverAProductos();

    public partial class Stocks : UserControl, Interfaz
    {
        public event volverAProductos btnIrAtras;

        public Stocks()
        {
            InitializeComponent();
        }

        //Métodos
        public void Clear()
        {

        }

        public void ActualizarPantalla()
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.btnIrAtras();
        }
    }
}
