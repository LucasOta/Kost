﻿namespace Kost
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
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
            this.dgvVentasDiarias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mozo,
            this.Comanda,
            this.Importe});
            this.dgvVentasDiarias.Location = new System.Drawing.Point(7, 100);
            this.dgvVentasDiarias.Name = "dgvVentasDiarias";
            this.dgvVentasDiarias.ReadOnly = true;
            this.dgvVentasDiarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasDiarias.Size = new System.Drawing.Size(814, 397);
            this.dgvVentasDiarias.TabIndex = 21;
            // 
            // dtpVentasDiarias
            // 
            this.dtpVentasDiarias.Location = new System.Drawing.Point(615, 40);
            this.dtpVentasDiarias.Name = "dtpVentasDiarias";
            this.dtpVentasDiarias.Size = new System.Drawing.Size(200, 27);
            this.dtpVentasDiarias.TabIndex = 22;
            this.dtpVentasDiarias.ValueChanged += new System.EventHandler(this.dtpVentasDiarias_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(594, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(179, 21);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total que se vendió: $";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(21, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(188, 30);
            this.lblProducto.TabIndex = 33;
            this.lblProducto.Text = "Ventas por Día";
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
            this.Comanda.Width = 280;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "precioFinal";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 190;
            // 
            // VentasPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpVentasDiarias);
            this.Controls.Add(this.dgvVentasDiarias);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VentasPorDia";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDiarias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasDiarias;
        private System.Windows.Forms.DateTimePicker dtpVentasDiarias;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}
