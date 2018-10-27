namespace Kost
{
    partial class VentasPorMozo
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
            this.dgvVentasPorMozo = new System.Windows.Forms.DataGridView();
            this.dtpVentasMozo = new System.Windows.Forms.DateTimePicker();
            this.cbxMozo = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasPorMozo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasPorMozo
            // 
            this.dgvVentasPorMozo.AllowUserToAddRows = false;
            this.dgvVentasPorMozo.AllowUserToDeleteRows = false;
            this.dgvVentasPorMozo.AllowUserToOrderColumns = true;
            this.dgvVentasPorMozo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasPorMozo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdComanda,
            this.FechaHora,
            this.Total});
            this.dgvVentasPorMozo.Location = new System.Drawing.Point(288, 14);
            this.dgvVentasPorMozo.Name = "dgvVentasPorMozo";
            this.dgvVentasPorMozo.ReadOnly = true;
            this.dgvVentasPorMozo.Size = new System.Drawing.Size(494, 483);
            this.dgvVentasPorMozo.TabIndex = 21;
            // 
            // dtpVentasMozo
            // 
            this.dtpVentasMozo.Location = new System.Drawing.Point(17, 38);
            this.dtpVentasMozo.Name = "dtpVentasMozo";
            this.dtpVentasMozo.Size = new System.Drawing.Size(200, 27);
            this.dtpVentasMozo.TabIndex = 22;
            // 
            // cbxMozo
            // 
            this.cbxMozo.FormattingEnabled = true;
            this.cbxMozo.Location = new System.Drawing.Point(17, 107);
            this.cbxMozo.Name = "cbxMozo";
            this.cbxMozo.Size = new System.Drawing.Size(200, 29);
            this.cbxMozo.TabIndex = 23;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(587, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(195, 21);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total que vendió: $XXXX";
            this.lblTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mozo";
            // 
            // IdComanda
            // 
            this.IdComanda.HeaderText = "ID Comanda";
            this.IdComanda.Name = "IdComanda";
            this.IdComanda.ReadOnly = true;
            this.IdComanda.Width = 150;
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "Fecha y hora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            this.FechaHora.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // VentasPorMozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbxMozo);
            this.Controls.Add(this.dtpVentasMozo);
            this.Controls.Add(this.dgvVentasPorMozo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VentasPorMozo";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasPorMozo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasPorMozo;
        private System.Windows.Forms.DateTimePicker dtpVentasMozo;
        private System.Windows.Forms.ComboBox cbxMozo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
