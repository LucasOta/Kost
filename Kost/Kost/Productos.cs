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

    public partial class Productos : UserControl
    {
        public event irProductoCompuestoEventHandler btnIrCompuesto;

        public event irProductoSimpleEventHandler btnIrSimple;

        public Productos()
        {
            InitializeComponent();
        }

        private void btnAgregarCompuesto_Click(object sender, EventArgs e)
        {
            this.btnIrCompuesto();
        }

        private void btnAgregarSimple_Click(object sender, EventArgs e)
        {
            this.btnIrSimple();
        }
    }
}
