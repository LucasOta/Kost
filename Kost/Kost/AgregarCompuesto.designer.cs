namespace Kost
{
    partial class AgregarCompuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCompuesto));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxComponente = new System.Windows.Forms.ComboBox();
            this.lblComponentes = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(332, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 27);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.AllowUserToDeleteRows = false;
            this.dgvComponentes.AllowUserToOrderColumns = true;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insumo,
            this.Cantidad});
            this.dgvComponentes.Location = new System.Drawing.Point(437, 257);
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.Size = new System.Drawing.Size(371, 173);
            this.dgvComponentes.TabIndex = 7;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            this.Insumo.Width = 160;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 160;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(332, 299);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 27);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(278, 257);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 27);
            this.txtCantidad.TabIndex = 6;
            // 
            // cbxComponente
            // 
            this.cbxComponente.FormattingEnabled = true;
            this.cbxComponente.Location = new System.Drawing.Point(153, 257);
            this.cbxComponente.Name = "cbxComponente";
            this.cbxComponente.Size = new System.Drawing.Size(119, 29);
            this.cbxComponente.TabIndex = 5;
            // 
            // lblComponentes
            // 
            this.lblComponentes.AutoSize = true;
            this.lblComponentes.Location = new System.Drawing.Point(28, 260);
            this.lblComponentes.Name = "lblComponentes";
            this.lblComponentes.Size = new System.Drawing.Size(122, 21);
            this.lblComponentes.TabIndex = 51;
            this.lblComponentes.Text = "Componentes";
            this.lblComponentes.Click += new System.EventHandler(this.lblComponentes_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(153, 149);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(250, 29);
            this.cbxCategoria.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(563, 483);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(451, 483);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 32);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(27, 28);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(356, 30);
            this.lblProducto.TabIndex = 50;
            this.lblProducto.Text = "Nuevo Producto Compuesto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(153, 218);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(250, 27);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(153, 185);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(250, 27);
            this.txtCosto.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 119);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcion.TabIndex = 46;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(28, 152);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 21);
            this.lblCategoria.TabIndex = 47;
            this.lblCategoria.Text = "Categoría";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(153, 116);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 27);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(28, 188);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(56, 21);
            this.lblCosto.TabIndex = 48;
            this.lblCosto.Text = "Costo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(28, 221);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 21);
            this.lblPrecio.TabIndex = 49;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(676, 483);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(132, 32);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // AgregarCompuesto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvComponentes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxComponente);
            this.Controls.Add(this.lblComponentes);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnAtras);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AgregarCompuesto";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxComponente;
        private System.Windows.Forms.Label lblComponentes;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAtras;
    }
}
