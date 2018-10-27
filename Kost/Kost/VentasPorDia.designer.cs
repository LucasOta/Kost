namespace Kost
{
    partial class VentasPorDia
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
            this.dgvVentasDiarias = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpVentasDiarias = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDiarias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasDiarias
            // 
            this.dgvVentasDiarias.AllowUserToAddRows = false;
            this.dgvVentasDiarias.AllowUserToDeleteRows = false;
            this.dgvVentasDiarias.AllowUserToOrderColumns = true;
            this.dgvVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Vendido});
            this.dgvVentasDiarias.Location = new System.Drawing.Point(7, 48);
            this.dgvVentasDiarias.Name = "dgvVentasDiarias";
            this.dgvVentasDiarias.ReadOnly = true;
            this.dgvVentasDiarias.Size = new System.Drawing.Size(814, 479);
            this.dgvVentasDiarias.TabIndex = 21;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 385;
            // 
            // Vendido
            // 
            this.Vendido.HeaderText = "Total Vendido";
            this.Vendido.Name = "Vendido";
            this.Vendido.ReadOnly = true;
            this.Vendido.Width = 385;
            // 
            // dtpVentasDiarias
            // 
            this.dtpVentasDiarias.Location = new System.Drawing.Point(7, 15);
            this.dtpVentasDiarias.Name = "dtpVentasDiarias";
            this.dtpVentasDiarias.Size = new System.Drawing.Size(200, 27);
            this.dtpVentasDiarias.TabIndex = 22;
            // 
            // VentasPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpVentasDiarias);
            this.Controls.Add(this.dgvVentasDiarias);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VentasPorDia";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDiarias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasDiarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendido;
        private System.Windows.Forms.DateTimePicker dtpVentasDiarias;
    }
}
