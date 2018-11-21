namespace Kost
{
    partial class InsumosUtilizados
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
            this.dgvInsumosUtilizados = new System.Windows.Forms.DataGridView();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpInsumosUtilizados = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosUtilizados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInsumosUtilizados
            // 
            this.dgvInsumosUtilizados.AllowUserToAddRows = false;
            this.dgvInsumosUtilizados.AllowUserToDeleteRows = false;
            this.dgvInsumosUtilizados.AllowUserToResizeColumns = false;
            this.dgvInsumosUtilizados.AllowUserToResizeRows = false;
            this.dgvInsumosUtilizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumosUtilizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insumo,
            this.Cantidad});
            this.dgvInsumosUtilizados.Location = new System.Drawing.Point(3, 68);
            this.dgvInsumosUtilizados.Name = "dgvInsumosUtilizados";
            this.dgvInsumosUtilizados.ReadOnly = true;
            this.dgvInsumosUtilizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumosUtilizados.Size = new System.Drawing.Size(818, 446);
            this.dgvInsumosUtilizados.TabIndex = 16;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            this.Insumo.Width = 385;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Catidad Utilizada";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 385;
            // 
            // dtpInsumosUtilizados
            // 
            this.dtpInsumosUtilizados.Location = new System.Drawing.Point(3, 17);
            this.dtpInsumosUtilizados.Name = "dtpInsumosUtilizados";
            this.dtpInsumosUtilizados.Size = new System.Drawing.Size(200, 27);
            this.dtpInsumosUtilizados.TabIndex = 18;
            // 
            // InsumosUtilizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpInsumosUtilizados);
            this.Controls.Add(this.dgvInsumosUtilizados);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InsumosUtilizados";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosUtilizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInsumosUtilizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DateTimePicker dtpInsumosUtilizados;
    }
}
