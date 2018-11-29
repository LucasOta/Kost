namespace Kost
{
    partial class ComandasActivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComandasActivas));
            this.btnIrAComanda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlComanda = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxMozo = new System.Windows.Forms.ComboBox();
            this.lblMozo = new System.Windows.Forms.Label();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvComandasActivas = new System.Windows.Forms.DataGridView();
            this.N_Comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandasActivas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIrAComanda
            // 
            this.btnIrAComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIrAComanda.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnIrAComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrAComanda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrAComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrAComanda.Location = new System.Drawing.Point(685, 483);
            this.btnIrAComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnIrAComanda.Name = "btnIrAComanda";
            this.btnIrAComanda.Size = new System.Drawing.Size(132, 40);
            this.btnIrAComanda.TabIndex = 15;
            this.btnIrAComanda.Text = "Ir a Comanda";
            this.btnIrAComanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIrAComanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIrAComanda.UseVisualStyleBackColor = true;
            this.btnIrAComanda.Click += new System.EventHandler(this.btnIrAComanda_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(609, 103);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(208, 40);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Comanda";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(609, 55);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(208, 40);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar Comanda";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(609, 7);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 40);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Comanda";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // pnlComanda
            // 
            this.pnlComanda.Controls.Add(this.btnCancelar);
            this.pnlComanda.Controls.Add(this.btnGuardar);
            this.pnlComanda.Controls.Add(this.cbxMozo);
            this.pnlComanda.Controls.Add(this.lblMozo);
            this.pnlComanda.Controls.Add(this.cbxMesa);
            this.pnlComanda.Controls.Add(this.lblMesa);
            this.pnlComanda.Controls.Add(this.label6);
            this.pnlComanda.Location = new System.Drawing.Point(565, 229);
            this.pnlComanda.Name = "pnlComanda";
            this.pnlComanda.Size = new System.Drawing.Size(251, 205);
            this.pnlComanda.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(154, 162);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(154, 127);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 32);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // cbxMozo
            // 
            this.cbxMozo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMozo.FormattingEnabled = true;
            this.cbxMozo.Location = new System.Drawing.Point(83, 84);
            this.cbxMozo.Name = "cbxMozo";
            this.cbxMozo.Size = new System.Drawing.Size(163, 29);
            this.cbxMozo.TabIndex = 6;
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMozo.Location = new System.Drawing.Point(3, 84);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(52, 21);
            this.lblMozo.TabIndex = 12;
            this.lblMozo.Text = "Mozo";
            // 
            // cbxMesa
            // 
            this.cbxMesa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(83, 49);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(163, 29);
            this.cbxMesa.TabIndex = 5;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(3, 49);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(74, 21);
            this.lblMesa.TabIndex = 11;
            this.lblMesa.Text = "N° Mesa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Comanda";
            // 
            // dgvComandasActivas
            // 
            this.dgvComandasActivas.AllowUserToAddRows = false;
            this.dgvComandasActivas.AllowUserToDeleteRows = false;
            this.dgvComandasActivas.AllowUserToResizeColumns = false;
            this.dgvComandasActivas.AllowUserToResizeRows = false;
            this.dgvComandasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Comanda,
            this.N_Mesa,
            this.Mozo});
            this.dgvComandasActivas.Location = new System.Drawing.Point(3, 6);
            this.dgvComandasActivas.Name = "dgvComandasActivas";
            this.dgvComandasActivas.ReadOnly = true;
            this.dgvComandasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComandasActivas.Size = new System.Drawing.Size(533, 518);
            this.dgvComandasActivas.TabIndex = 10;
            // 
            // N_Comanda
            // 
            this.N_Comanda.DataPropertyName = "nroComanda";
            this.N_Comanda.Frozen = true;
            this.N_Comanda.HeaderText = "Comanda";
            this.N_Comanda.Name = "N_Comanda";
            this.N_Comanda.ReadOnly = true;
            this.N_Comanda.Width = 130;
            // 
            // N_Mesa
            // 
            this.N_Mesa.DataPropertyName = "nroMesa";
            this.N_Mesa.Frozen = true;
            this.N_Mesa.HeaderText = "Mesa";
            this.N_Mesa.Name = "N_Mesa";
            this.N_Mesa.ReadOnly = true;
            this.N_Mesa.Width = 75;
            // 
            // Mozo
            // 
            this.Mozo.DataPropertyName = "nya";
            this.Mozo.Frozen = true;
            this.Mozo.HeaderText = "Mozo";
            this.Mozo.Name = "Mozo";
            this.Mozo.ReadOnly = true;
            this.Mozo.Width = 295;
            // 
            // ComandasActivas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnIrAComanda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlComanda);
            this.Controls.Add(this.dgvComandasActivas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ComandasActivas";
            this.Size = new System.Drawing.Size(825, 530);
            this.pnlComanda.ResumeLayout(false);
            this.pnlComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandasActivas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIrAComanda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlComanda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxMozo;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.ComboBox cbxMesa;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvComandasActivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mozo;
    }
}
