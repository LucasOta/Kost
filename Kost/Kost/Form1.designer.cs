namespace Kost
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.desplegableRep = new System.Windows.Forms.Panel();
            this.btnVentasDiarias = new System.Windows.Forms.Button();
            this.btnVentasPorMozo = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnPrecioPorCat = new System.Windows.Forms.Button();
            this.indicadorBtn = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMozo = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnComandas = new System.Windows.Forms.Button();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.agregarSimple1 = new Kost.AgregarSimple();
            this.agregarCompuesto1 = new Kost.AgregarCompuesto();
            this.productos1 = new Kost.Productos();
            this.mozos1 = new Kost.Mozos();
            this.comanda1 = new Kost.Comanda();
            this.comandasActivas1 = new Kost.ComandasActivas();
            this.usuarios1 = new Kost.Usuarios();
            this.login1 = new Kost.Login();
            this.stocks1 = new Kost.Stocks();
            this.precioPorCategoria1 = new Kost.PrecioPorCategoria();
            this.ventasPorMozo1 = new Kost.VentasPorMozo();
            this.ventasPorDia1 = new Kost.VentasPorDia();
            this.insumosUtilizados1 = new Kost.InsumosUtilizados();
            this.panel1.SuspendLayout();
            this.desplegableRep.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.desplegableRep);
            this.panel1.Controls.Add(this.indicadorBtn);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnMozo);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnComandas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 562);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(6, 518);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(162, 40);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 100);
            this.panel3.TabIndex = 10;
            // 
            // desplegableRep
            // 
            this.desplegableRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.desplegableRep.Controls.Add(this.btnVentasDiarias);
            this.desplegableRep.Controls.Add(this.btnVentasPorMozo);
            this.desplegableRep.Controls.Add(this.btnInsumos);
            this.desplegableRep.Controls.Add(this.btnPrecioPorCat);
            this.desplegableRep.Location = new System.Drawing.Point(13, 348);
            this.desplegableRep.Name = "desplegableRep";
            this.desplegableRep.Size = new System.Drawing.Size(162, 135);
            this.desplegableRep.TabIndex = 9;
            // 
            // btnVentasDiarias
            // 
            this.btnVentasDiarias.FlatAppearance.BorderSize = 0;
            this.btnVentasDiarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasDiarias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasDiarias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasDiarias.Location = new System.Drawing.Point(0, 99);
            this.btnVentasDiarias.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentasDiarias.Name = "btnVentasDiarias";
            this.btnVentasDiarias.Size = new System.Drawing.Size(158, 35);
            this.btnVentasDiarias.TabIndex = 10;
            this.btnVentasDiarias.Text = "Ventas Diarias";
            this.btnVentasDiarias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasDiarias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentasDiarias.UseVisualStyleBackColor = true;
            this.btnVentasDiarias.Click += new System.EventHandler(this.btnVentasDiarias_Click);
            // 
            // btnVentasPorMozo
            // 
            this.btnVentasPorMozo.FlatAppearance.BorderSize = 0;
            this.btnVentasPorMozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasPorMozo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasPorMozo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasPorMozo.Location = new System.Drawing.Point(0, 66);
            this.btnVentasPorMozo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentasPorMozo.Name = "btnVentasPorMozo";
            this.btnVentasPorMozo.Size = new System.Drawing.Size(158, 35);
            this.btnVentasPorMozo.TabIndex = 9;
            this.btnVentasPorMozo.Text = "Ventas por Mozo";
            this.btnVentasPorMozo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasPorMozo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentasPorMozo.UseVisualStyleBackColor = true;
            this.btnVentasPorMozo.Click += new System.EventHandler(this.btnVentasPorMozo_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumos.Location = new System.Drawing.Point(0, 34);
            this.btnInsumos.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(158, 35);
            this.btnInsumos.TabIndex = 8;
            this.btnInsumos.Text = "Insumos Utilizados";
            this.btnInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btnPrecioPorCat
            // 
            this.btnPrecioPorCat.FlatAppearance.BorderSize = 0;
            this.btnPrecioPorCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioPorCat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioPorCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecioPorCat.Location = new System.Drawing.Point(0, 1);
            this.btnPrecioPorCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrecioPorCat.Name = "btnPrecioPorCat";
            this.btnPrecioPorCat.Size = new System.Drawing.Size(158, 35);
            this.btnPrecioPorCat.TabIndex = 7;
            this.btnPrecioPorCat.Text = "Precio por Categoría";
            this.btnPrecioPorCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecioPorCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrecioPorCat.UseVisualStyleBackColor = true;
            this.btnPrecioPorCat.Click += new System.EventHandler(this.btnPrecioPorCat_Click);
            // 
            // indicadorBtn
            // 
            this.indicadorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(239)))), ((int)(((byte)(185)))));
            this.indicadorBtn.Location = new System.Drawing.Point(3, 109);
            this.indicadorBtn.Name = "indicadorBtn";
            this.indicadorBtn.Size = new System.Drawing.Size(10, 43);
            this.indicadorBtn.TabIndex = 5;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(13, 301);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(162, 40);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = " Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(13, 253);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(162, 40);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = " Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnMozo
            // 
            this.btnMozo.FlatAppearance.BorderSize = 0;
            this.btnMozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMozo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMozo.Image = ((System.Drawing.Image)(resources.GetObject("btnMozo.Image")));
            this.btnMozo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMozo.Location = new System.Drawing.Point(13, 205);
            this.btnMozo.Margin = new System.Windows.Forms.Padding(4);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(162, 40);
            this.btnMozo.TabIndex = 2;
            this.btnMozo.Text = " Mozo";
            this.btnMozo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMozo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(13, 157);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(162, 40);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = " Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnComandas
            // 
            this.btnComandas.FlatAppearance.BorderSize = 0;
            this.btnComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComandas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandas.Image = ((System.Drawing.Image)(resources.GetObject("btnComandas.Image")));
            this.btnComandas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComandas.Location = new System.Drawing.Point(13, 109);
            this.btnComandas.Margin = new System.Windows.Forms.Padding(4);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(162, 40);
            this.btnComandas.TabIndex = 0;
            this.btnComandas.Text = " Comandas";
            this.btnComandas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComandas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComandas.UseVisualStyleBackColor = true;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.pnlBarra.Controls.Add(this.btnCerrar);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(175, 0);
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(825, 33);
            this.pnlBarra.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(784, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 29);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // agregarSimple1
            // 
            this.agregarSimple1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarSimple1.ForeColor = System.Drawing.Color.Black;
            this.agregarSimple1.Location = new System.Drawing.Point(175, 33);
            this.agregarSimple1.Name = "agregarSimple1";
            this.agregarSimple1.Size = new System.Drawing.Size(825, 530);
            this.agregarSimple1.TabIndex = 10;
            // 
            // agregarCompuesto1
            // 
            this.agregarCompuesto1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCompuesto1.ForeColor = System.Drawing.Color.Black;
            this.agregarCompuesto1.Location = new System.Drawing.Point(175, 33);
            this.agregarCompuesto1.Name = "agregarCompuesto1";
            this.agregarCompuesto1.Size = new System.Drawing.Size(825, 530);
            this.agregarCompuesto1.TabIndex = 9;
            // 
            // productos1
            // 
            this.productos1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos1.ForeColor = System.Drawing.Color.Black;
            this.productos1.Location = new System.Drawing.Point(175, 34);
            this.productos1.Margin = new System.Windows.Forms.Padding(5);
            this.productos1.Name = "productos1";
            this.productos1.Size = new System.Drawing.Size(825, 530);
            this.productos1.TabIndex = 7;
            // 
            // mozos1
            // 
            this.mozos1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mozos1.ForeColor = System.Drawing.Color.Black;
            this.mozos1.Location = new System.Drawing.Point(175, 33);
            this.mozos1.Margin = new System.Windows.Forms.Padding(5);
            this.mozos1.Name = "mozos1";
            this.mozos1.Size = new System.Drawing.Size(825, 530);
            this.mozos1.TabIndex = 6;
            // 
            // comanda1
            // 
            this.comanda1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comanda1.ForeColor = System.Drawing.Color.Black;
            this.comanda1.Location = new System.Drawing.Point(175, 33);
            this.comanda1.Name = "comanda1";
            this.comanda1.Size = new System.Drawing.Size(825, 530);
            this.comanda1.TabIndex = 5;
            // 
            // comandasActivas1
            // 
            this.comandasActivas1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.comandasActivas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comandasActivas1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comandasActivas1.ForeColor = System.Drawing.Color.Black;
            this.comandasActivas1.Location = new System.Drawing.Point(175, 33);
            this.comandasActivas1.Margin = new System.Windows.Forms.Padding(0);
            this.comandasActivas1.Name = "comandasActivas1";
            this.comandasActivas1.Size = new System.Drawing.Size(825, 529);
            this.comandasActivas1.TabIndex = 3;
            // 
            // usuarios1
            // 
            this.usuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarios1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarios1.ForeColor = System.Drawing.Color.Black;
            this.usuarios1.Location = new System.Drawing.Point(0, 0);
            this.usuarios1.Name = "usuarios1";
            this.usuarios1.Size = new System.Drawing.Size(1000, 562);
            this.usuarios1.TabIndex = 4;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.login1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Margin = new System.Windows.Forms.Padding(5);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1000, 562);
            this.login1.TabIndex = 8;
            // 
            // stocks1
            // 
            this.stocks1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocks1.ForeColor = System.Drawing.Color.Black;
            this.stocks1.Location = new System.Drawing.Point(175, 33);
            this.stocks1.Margin = new System.Windows.Forms.Padding(5);
            this.stocks1.Name = "stocks1";
            this.stocks1.Size = new System.Drawing.Size(825, 530);
            this.stocks1.TabIndex = 11;
            // 
            // precioPorCategoria1
            // 
            this.precioPorCategoria1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioPorCategoria1.ForeColor = System.Drawing.Color.Black;
            this.precioPorCategoria1.Location = new System.Drawing.Point(175, 33);
            this.precioPorCategoria1.Margin = new System.Windows.Forms.Padding(5);
            this.precioPorCategoria1.Name = "precioPorCategoria1";
            this.precioPorCategoria1.Size = new System.Drawing.Size(825, 530);
            this.precioPorCategoria1.TabIndex = 12;
            // 
            // ventasPorMozo1
            // 
            this.ventasPorMozo1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasPorMozo1.ForeColor = System.Drawing.Color.Black;
            this.ventasPorMozo1.Location = new System.Drawing.Point(175, 33);
            this.ventasPorMozo1.Margin = new System.Windows.Forms.Padding(5);
            this.ventasPorMozo1.Name = "ventasPorMozo1";
            this.ventasPorMozo1.Size = new System.Drawing.Size(825, 530);
            this.ventasPorMozo1.TabIndex = 13;
            // 
            // ventasPorDia1
            // 
            this.ventasPorDia1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasPorDia1.ForeColor = System.Drawing.Color.Black;
            this.ventasPorDia1.Location = new System.Drawing.Point(175, 33);
            this.ventasPorDia1.Margin = new System.Windows.Forms.Padding(5);
            this.ventasPorDia1.Name = "ventasPorDia1";
            this.ventasPorDia1.Size = new System.Drawing.Size(825, 530);
            this.ventasPorDia1.TabIndex = 14;
            // 
            // insumosUtilizados1
            // 
            this.insumosUtilizados1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insumosUtilizados1.ForeColor = System.Drawing.Color.Black;
            this.insumosUtilizados1.Location = new System.Drawing.Point(175, 33);
            this.insumosUtilizados1.Margin = new System.Windows.Forms.Padding(5);
            this.insumosUtilizados1.Name = "insumosUtilizados1";
            this.insumosUtilizados1.Size = new System.Drawing.Size(825, 530);
            this.insumosUtilizados1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.insumosUtilizados1);
            this.Controls.Add(this.ventasPorDia1);
            this.Controls.Add(this.ventasPorMozo1);
            this.Controls.Add(this.precioPorCategoria1);
            this.Controls.Add(this.stocks1);
            this.Controls.Add(this.agregarSimple1);
            this.Controls.Add(this.agregarCompuesto1);
            this.Controls.Add(this.productos1);
            this.Controls.Add(this.mozos1);
            this.Controls.Add(this.comanda1);
            this.Controls.Add(this.comandasActivas1);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usuarios1);
            this.Controls.Add(this.login1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.desplegableRep.ResumeLayout(false);
            this.pnlBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel indicadorBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private Usuarios usuarios1;
        private System.Windows.Forms.Panel desplegableRep;
        private System.Windows.Forms.Button btnPrecioPorCat;
        private System.Windows.Forms.Button btnVentasDiarias;
        private System.Windows.Forms.Button btnVentasPorMozo;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private Mozos mozos1;
        private Productos productos1;
        private Comanda comanda1;
        private ComandasActivas comandasActivas1;
        private Login login1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private AgregarCompuesto agregarCompuesto1;
        private AgregarSimple agregarSimple1;
        private Stocks stocks1;
        private PrecioPorCategoria precioPorCategoria1;
        private VentasPorMozo ventasPorMozo1;
        private VentasPorDia ventasPorDia1;
        private InsumosUtilizados insumosUtilizados1;
    }
}

