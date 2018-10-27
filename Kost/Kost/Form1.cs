using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            indicadorBtn.Height = btnComandas.Height;

            esconderDesplegables();

            login1.BringToFront();

            comandasActivas1.btnIrAComandaCLick += new Kost.irAComandaEventHandler(IrAComanda);
            comanda1.btnIrAAtrasCLick += new Kost.volverAComandasActivasEventHandler(AtrasComanda);
            comanda1.cerrarComanda += new Kost.cerrarComandaEventHandler(CerrarComanda);
            productos1.btnIrCompuesto += new Kost.irProductoCompuestoEventHandler(IrProductoCompuesto);
            productos1.btnIrSimple += new Kost.irProductoSimpleEventHandler(IrProductoSimple);

            login1.Inicio_0 += new Kost.Inicio_0_EventHandler(sinSesion);
            login1.Inicio_1 += new Kost.Inicio_1_EventHandler(admin);
            login1.Inicio_2 += new Kost.Inicio_2_EventHandler(usuario);

            login1.Cerrar += new Kost.Cerrar_LoginEventHandler(Cerrar);

            this.sinSesion();
        }


        //Botones
        private void btnComandas_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

            indicadorBtn.Height = btnComandas.Height;
            indicadorBtn.Top = btnComandas.Top;
            comandasActivas1.BringToFront();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

            indicadorBtn.Height = btnUsuario.Height;
            indicadorBtn.Top = btnUsuario.Top;
            usuarios1.BringToFront();
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

            indicadorBtn.Height = btnMozo.Height;
            indicadorBtn.Top = btnMozo.Top;

            mozos1.BringToFront();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

            indicadorBtn.Height = btnProductos.Height;
            indicadorBtn.Top = btnProductos.Top;

            productos1.BringToFront();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

            indicadorBtn.Height = btnReportes.Height;
            indicadorBtn.Top = btnReportes.Top;

            desplegableRep.BringToFront();
            desplegableRep.Visible = true;
        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgrSimple_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

            indicadorBtn.Height = btnReportes.Height;
            indicadorBtn.Top = btnReportes.Top;
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            LimpiarTodo();            

            indicadorBtn.Height = btnReportes.Height;
            indicadorBtn.Top = btnReportes.Top;            
        }


        //Métodos
        private void IrAComanda(int n)
        {
            comanda1.setComanda(n);
            comanda1.BringToFront();
        }

        private void AtrasComanda()
        {
            comandasActivas1.BringToFront();
        }

        private void CerrarComanda()
        {
            comandasActivas1.CargarDGV();
        }

        private void esconderDesplegables()
        {
            desplegableRep.Visible = false;
            desplegableRep.SendToBack();
            btnReportes.Top = btnProductos.Bottom;
            desplegableRep.Top = btnReportes.Bottom;
        }

        private void LimpiarTodo() {
            //comanda1.Clear();
            usuarios1.Clear();
            mozos1.Clear();
            //productos1.Clear();
            // y limpiar todos los reportes
            esconderDesplegables();
        }

        private void Cerrar() {
            this.Dispose();
        }

        private void IrProductoCompuesto()
        {

        }

        private void IrProductoSimple()
        {

        }

        //Mostrar según Usuario
        public void sinSesion()
        {
            btnComandas.Enabled = false;
            btnComandas.Visible = false;
            btnUsuario.Enabled = false;
            btnUsuario.Visible = false;
            btnMozo.Enabled = false;
            btnMozo.Visible = false;
            btnProductos.Enabled = false;
            btnProductos.Visible = false;
            btnReportes.Enabled = false;
            btnReportes.Visible = false;
            esconderDesplegables();
        }

        public void usuario()
        {
            btnComandas.Enabled = true;
            btnComandas.Visible = true;
            btnUsuario.Enabled = false;
            btnUsuario.Visible = false;
            btnMozo.Enabled = false;
            btnMozo.Visible = false;
            btnProductos.Enabled = false;
            btnProductos.Visible = false;
            btnReportes.Enabled = false;
            btnReportes.Visible = false;
            esconderDesplegables();
            btnComandas.PerformClick();

            login1.Visible = false;
            login1.SendToBack();
        }

        public void admin()
        {
            btnComandas.Enabled = true;
            btnComandas.Visible = true;
            btnUsuario.Enabled = true;
            btnUsuario.Visible = true;
            btnMozo.Enabled = true;
            btnMozo.Visible = true;
            btnProductos.Enabled = true;
            btnProductos.Visible = true;
            btnReportes.Enabled = true;
            btnReportes.Visible = true;
            esconderDesplegables();
            btnComandas.PerformClick();
            login1.Visible = false;
            login1.SendToBack();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            btnComandas.Enabled = false;
            btnComandas.Visible = false;
            btnUsuario.Enabled = false;
            btnUsuario.Visible = false;
            btnMozo.Enabled = false;
            btnMozo.Visible = false;
            btnProductos.Enabled = false;
            btnProductos.Visible = false;
            btnReportes.Enabled = false;
            btnReportes.Visible = false;
            esconderDesplegables();

            login1.Clear();
            login1.Visible = true;
            login1.BringToFront();
        }
    }
}
