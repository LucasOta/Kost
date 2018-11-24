namespace Kost
{
    partial class Comanda
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comanda));
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblTituloDescuento = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.N_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.lblMozo = new System.Windows.Forms.Label();
            this.lblNumeroComanda = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCerrarComanda = new System.Windows.Forms.Button();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(713, 196);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(109, 27);
            this.txtDescuento.TabIndex = 11;
            // 
            // lblTituloDescuento
            // 
            this.lblTituloDescuento.AutoSize = true;
            this.lblTituloDescuento.Location = new System.Drawing.Point(607, 199);
            this.lblTituloDescuento.Name = "lblTituloDescuento";
            this.lblTituloDescuento.Size = new System.Drawing.Size(95, 21);
            this.lblTituloDescuento.TabIndex = 33;
            this.lblTituloDescuento.Text = "Descuento";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.lblPrecioUnitario);
            this.pnlDetalle.Controls.Add(this.lbl1);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Controls.Add(this.lblProducto);
            this.pnlDetalle.Controls.Add(this.label6);
            this.pnlDetalle.Controls.Add(this.lblCantidad);
            this.pnlDetalle.Controls.Add(this.cbxProducto);
            this.pnlDetalle.Controls.Add(this.txtCantidad);
            this.pnlDetalle.Location = new System.Drawing.Point(7, 259);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(331, 214);
            this.pnlDetalle.TabIndex = 4;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(327, 69);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(0, 21);
            this.lblPrecioUnitario.TabIndex = 81;
            this.lblPrecioUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(30, 69);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(99, 21);
            this.lbl1.TabIndex = 43;
            this.lbl1.Text = "Precio unit. ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(234, 180);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(234, 145);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 27);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(29, 29);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(82, 21);
            this.lblProducto.TabIndex = 70;
            this.lblProducto.Text = "Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Detalle";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(29, 103);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(87, 21);
            this.lblCantidad.TabIndex = 80;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(150, 29);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(177, 29);
            this.cbxProducto.TabIndex = 5;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(150, 100);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(177, 27);
            this.txtCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(709, 243);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 21);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "$ XXXX";
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Location = new System.Drawing.Point(642, 243);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(53, 21);
            this.lblTituloTotal.TabIndex = 24;
            this.lblTituloTotal.Text = "Total:";
            // 
            // dgvComanda
            // 
            this.dgvComanda.AllowUserToAddRows = false;
            this.dgvComanda.AllowUserToDeleteRows = false;
            this.dgvComanda.AllowUserToResizeColumns = false;
            this.dgvComanda.AllowUserToResizeRows = false;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Detalle,
            this.Codigo_Producto,
            this.Cantidad,
            this.Descripcion,
            this.Precio,
            this.Subtotal});
            this.dgvComanda.Location = new System.Drawing.Point(2, 39);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.ReadOnly = true;
            this.dgvComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComanda.Size = new System.Drawing.Size(820, 150);
            this.dgvComanda.TabIndex = 0;
            // 
            // N_Detalle
            // 
            this.N_Detalle.Frozen = true;
            this.N_Detalle.HeaderText = "N° Detalle";
            this.N_Detalle.Name = "N_Detalle";
            this.N_Detalle.ReadOnly = true;
            this.N_Detalle.Width = 120;
            // 
            // Codigo_Producto
            // 
            this.Codigo_Producto.Frozen = true;
            this.Codigo_Producto.HeaderText = "Cód. Producto";
            this.Codigo_Producto.Name = "Codigo_Producto";
            this.Codigo_Producto.ReadOnly = true;
            this.Codigo_Producto.Width = 160;
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Precio
            // 
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.Frozen = true;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Location = new System.Drawing.Point(187, 10);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(106, 21);
            this.lblNumeroMesa.TabIndex = 22;
            this.lblNumeroMesa.Text = "N° Mesa: ___";
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(340, 10);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(180, 21);
            this.lblMozo.TabIndex = 21;
            this.lblMozo.Text = "Mozo: _______________";
            // 
            // lblNumeroComanda
            // 
            this.lblNumeroComanda.AutoSize = true;
            this.lblNumeroComanda.Location = new System.Drawing.Point(3, 10);
            this.lblNumeroComanda.Name = "lblNumeroComanda";
            this.lblNumeroComanda.Size = new System.Drawing.Size(145, 21);
            this.lblNumeroComanda.TabIndex = 20;
            this.lblNumeroComanda.Text = "N° Comanda: ___";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(270, 196);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(131, 196);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(7, 196);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(689, 494);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(132, 32);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCerrarComanda
            // 
            this.btnCerrarComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarComanda.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCerrarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarComanda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarComanda.Location = new System.Drawing.Point(646, 454);
            this.btnCerrarComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarComanda.Name = "btnCerrarComanda";
            this.btnCerrarComanda.Size = new System.Drawing.Size(175, 32);
            this.btnCerrarComanda.TabIndex = 9;
            this.btnCerrarComanda.Text = "Cerrar Comanda";
            this.btnCerrarComanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarComanda.UseVisualStyleBackColor = true;
            // 
            // Comanda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCerrarComanda);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblTituloDescuento);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTituloTotal);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.lblMozo);
            this.Controls.Add(this.lblNumeroComanda);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Comanda";
            this.Size = new System.Drawing.Size(825, 530);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblTituloDescuento;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.Label lblNumeroComanda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnCerrarComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblPrecioUnitario;
    }
}
