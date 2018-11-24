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
            this.dtpVentasDiarias = new System.Windows.Forms.DateTimePicker();
            this.Mozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDiarias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasDiarias
            // 
            this.dgvVentasDiarias.AllowUserToAddRows = false;
            this.dgvVentasDiarias.AllowUserToDeleteRows = false;
            this.dgvVentasDiarias.AllowUserToResizeColumns = false;
            this.dgvVentasDiarias.AllowUserToResizeRows = false;
            this.dgvVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mozo,
            this.Comanda,
            this.Importe});
            this.dgvVentasDiarias.Location = new System.Drawing.Point(7, 48);
            this.dgvVentasDiarias.Name = "dgvVentasDiarias";
            this.dgvVentasDiarias.ReadOnly = true;
            this.dgvVentasDiarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasDiarias.Size = new System.Drawing.Size(814, 479);
            this.dgvVentasDiarias.TabIndex = 21;
            // 
            // dtpVentasDiarias
            // 
            this.dtpVentasDiarias.Location = new System.Drawing.Point(7, 15);
            this.dtpVentasDiarias.Name = "dtpVentasDiarias";
            this.dtpVentasDiarias.Size = new System.Drawing.Size(200, 27);
            this.dtpVentasDiarias.TabIndex = 22;
            this.dtpVentasDiarias.ValueChanged += new System.EventHandler(this.dtpVentasDiarias_ValueChanged);
            // 
            // Mozo
            // 
            this.Mozo.DataPropertyName = "mozo";
            this.Mozo.HeaderText = "Mozo";
            this.Mozo.Name = "Mozo";
            this.Mozo.ReadOnly = true;
            this.Mozo.Width = 300;
            // 
            // Comanda
            // 
            this.Comanda.DataPropertyName = "nroComanda";
            this.Comanda.HeaderText = "Comanda";
            this.Comanda.Name = "Comanda";
            this.Comanda.ReadOnly = true;
            this.Comanda.Width = 300;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "total";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 200;
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
        private System.Windows.Forms.DateTimePicker dtpVentasDiarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}
