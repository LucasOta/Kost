namespace Kost
{
    partial class Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtQuitar = new System.Windows.Forms.TextBox();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblTituloDescripcion = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(685, 491);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(132, 32);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(648, 254);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 34);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar Stock";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.btnGuardar);
            this.pnlProducto.Controls.Add(this.btnCancelar);
            this.pnlProducto.Controls.Add(this.txtQuitar);
            this.pnlProducto.Controls.Add(this.txtAgregar);
            this.pnlProducto.Controls.Add(this.lblDescripcion);
            this.pnlProducto.Controls.Add(this.lblNombre);
            this.pnlProducto.Controls.Add(this.lblQuitar);
            this.pnlProducto.Controls.Add(this.lblAgregar);
            this.pnlProducto.Controls.Add(this.lblTituloDescripcion);
            this.pnlProducto.Controls.Add(this.lblTituloNombre);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Location = new System.Drawing.Point(8, 254);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(479, 259);
            this.pnlProducto.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(269, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 35);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(380, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtQuitar
            // 
            this.txtQuitar.Location = new System.Drawing.Point(164, 165);
            this.txtQuitar.Name = "txtQuitar";
            this.txtQuitar.Size = new System.Drawing.Size(212, 27);
            this.txtQuitar.TabIndex = 1;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(164, 124);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(212, 27);
            this.txtAgregar.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(160, 86);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(216, 21);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "(Descripción del Producto)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(160, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(189, 21);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "(Nombre del Producto)";
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Location = new System.Drawing.Point(8, 168);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(60, 21);
            this.lblQuitar.TabIndex = 10;
            this.lblQuitar.Text = "Quitar";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(8, 127);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(76, 21);
            this.lblAgregar.TabIndex = 9;
            this.lblAgregar.Text = "Agregar";
            // 
            // lblTituloDescripcion
            // 
            this.lblTituloDescripcion.AutoSize = true;
            this.lblTituloDescripcion.Location = new System.Drawing.Point(8, 86);
            this.lblTituloDescripcion.Name = "lblTituloDescripcion";
            this.lblTituloDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lblTituloDescripcion.TabIndex = 7;
            this.lblTituloDescripcion.Text = "Descripción";
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Location = new System.Drawing.Point(8, 45);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(73, 21);
            this.lblTituloNombre.TabIndex = 5;
            this.lblTituloNombre.Text = "Nombre";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(4, 4);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(95, 22);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Cantidad});
            this.dgvProductos.Location = new System.Drawing.Point(8, 8);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(800, 239);
            this.dgvProductos.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 305;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Stocks";
            this.Size = new System.Drawing.Size(825, 530);
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtQuitar;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblQuitar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblTituloDescripcion;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}
