namespace Kost
{
    partial class Productos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarCompuesto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarSimple = new System.Windows.Forms.Button();
            this.btnVerStock = new System.Windows.Forms.Button();
            this.btnAdmCategorias = new System.Windows.Forms.Button();
            this.compuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(8, 482);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(182, 40);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(196, 482);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 40);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarCompuesto
            // 
            this.btnAgregarCompuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCompuesto.Location = new System.Drawing.Point(8, 402);
            this.btnAgregarCompuesto.Name = "btnAgregarCompuesto";
            this.btnAgregarCompuesto.Size = new System.Drawing.Size(182, 54);
            this.btnAgregarCompuesto.TabIndex = 1;
            this.btnAgregarCompuesto.Text = "Agregar Producto Compuesto";
            this.btnAgregarCompuesto.UseVisualStyleBackColor = true;
            this.btnAgregarCompuesto.Click += new System.EventHandler(this.btnAgregarCompuesto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Categoria,
            this.Precio,
            this.Tipo,
            this.compuesto});
            this.dgvProductos.Location = new System.Drawing.Point(8, 8);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(809, 388);
            this.dgvProductos.TabIndex = 0;
            // 
            // btnAgregarSimple
            // 
            this.btnAgregarSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSimple.Location = new System.Drawing.Point(196, 402);
            this.btnAgregarSimple.Name = "btnAgregarSimple";
            this.btnAgregarSimple.Size = new System.Drawing.Size(182, 54);
            this.btnAgregarSimple.TabIndex = 2;
            this.btnAgregarSimple.Text = "Agregar Producto Simple";
            this.btnAgregarSimple.UseVisualStyleBackColor = true;
            this.btnAgregarSimple.Click += new System.EventHandler(this.btnAgregarSimple_Click);
            // 
            // btnVerStock
            // 
            this.btnVerStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerStock.Location = new System.Drawing.Point(384, 482);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(182, 40);
            this.btnVerStock.TabIndex = 5;
            this.btnVerStock.Text = "Ver Stock";
            this.btnVerStock.UseVisualStyleBackColor = true;
            this.btnVerStock.Click += new System.EventHandler(this.btnVerStock_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "codProd";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 160;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripProd";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 245;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "categoria";
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precioVenta";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // btnAgregarSimple
            // 
            this.btnAgregarSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSimple.Location = new System.Drawing.Point(196, 402);
            this.btnAgregarSimple.Name = "btnAgregarSimple";
            this.btnAgregarSimple.Size = new System.Drawing.Size(182, 54);
            this.btnAgregarSimple.TabIndex = 2;
            this.btnAgregarSimple.Text = "Agregar Producto Simple";
            this.btnAgregarSimple.UseVisualStyleBackColor = true;
            this.btnAgregarSimple.Click += new System.EventHandler(this.btnAgregarSimple_Click);
            // 
            // btnVerStock
            // 
            this.btnVerStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerStock.Location = new System.Drawing.Point(384, 482);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(182, 40);
            this.btnVerStock.TabIndex = 5;
            this.btnVerStock.Text = "Ver Stock";
            this.btnVerStock.UseVisualStyleBackColor = true;
            this.btnVerStock.Click += new System.EventHandler(this.btnVerStock_Click);
            // 
            // btnAdmCategorias
            // 
            this.btnAdmCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmCategorias.Location = new System.Drawing.Point(635, 402);
            this.btnAdmCategorias.Name = "btnAdmCategorias";
            this.btnAdmCategorias.Size = new System.Drawing.Size(182, 54);
            this.btnAdmCategorias.TabIndex = 6;
            this.btnAdmCategorias.Text = "Administrar Categorías";
            this.btnAdmCategorias.UseVisualStyleBackColor = true;
            this.btnAdmCategorias.Click += new System.EventHandler(this.btnAdmCategorias_Click);
            // 
            // compuesto
            // 
            this.compuesto.DataPropertyName = "compuesto";
            this.compuesto.HeaderText = "Compuesto";
            this.compuesto.Name = "compuesto";
            this.compuesto.ReadOnly = true;
            this.compuesto.Visible = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdmCategorias);
            this.Controls.Add(this.btnVerStock);
            this.Controls.Add(this.btnAgregarSimple);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarCompuesto);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Productos";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarCompuesto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarSimple;
        private System.Windows.Forms.Button btnVerStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn compuesto;
        private System.Windows.Forms.Button btnAdmCategorias;
    }
}
