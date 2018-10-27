namespace Kost
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.txtCuil = new System.Windows.Forms.MaskedTextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNyA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.NyA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerUsuario = new System.Windows.Forms.Button();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.txtCuil);
            this.pnlUsuario.Controls.Add(this.dtpNacimiento);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Controls.Add(this.btnCancelar);
            this.pnlUsuario.Controls.Add(this.btnGuardar);
            this.pnlUsuario.Controls.Add(this.cbxNivel);
            this.pnlUsuario.Controls.Add(this.lblNivel);
            this.pnlUsuario.Controls.Add(this.txtContraseña);
            this.pnlUsuario.Controls.Add(this.lblContraseña);
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Controls.Add(this.lblNacimiento);
            this.pnlUsuario.Controls.Add(this.txtMail);
            this.pnlUsuario.Controls.Add(this.lblMail);
            this.pnlUsuario.Controls.Add(this.txtDireccion);
            this.pnlUsuario.Controls.Add(this.lblDireccion);
            this.pnlUsuario.Controls.Add(this.txtApellido);
            this.pnlUsuario.Controls.Add(this.lblDNI);
            this.pnlUsuario.Controls.Add(this.txtNombre);
            this.pnlUsuario.Controls.Add(this.lblNyA);
            this.pnlUsuario.Controls.Add(this.label6);
            this.pnlUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUsuario.Location = new System.Drawing.Point(427, 3);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(395, 425);
            this.pnlUsuario.TabIndex = 5;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(128, 108);
            this.txtCuil.Mask = "00-00000000-0";
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(263, 27);
            this.txtCuil.TabIndex = 7;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(128, 212);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(263, 27);
            this.dtpNacimiento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Apellido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(298, 386);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 15;
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
            this.btnGuardar.Location = new System.Drawing.Point(298, 351);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxNivel
            // 
            this.cbxNivel.FormattingEnabled = true;
            this.cbxNivel.Location = new System.Drawing.Point(128, 315);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(264, 29);
            this.cbxNivel.TabIndex = 13;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(10, 315);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(48, 21);
            this.lblNivel.TabIndex = 26;
            this.lblNivel.Text = "Nivel";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(128, 281);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(264, 27);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(10, 284);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(103, 21);
            this.lblContraseña.TabIndex = 25;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(128, 247);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(264, 27);
            this.txtUsuario.TabIndex = 11;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(10, 250);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 21);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(10, 212);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(101, 21);
            this.lblNacimiento.TabIndex = 23;
            this.lblNacimiento.Text = "Nacimiento";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(128, 175);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(264, 27);
            this.txtMail.TabIndex = 9;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(10, 178);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(42, 21);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "Mail";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(128, 141);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 27);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(10, 144);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 21);
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(128, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(264, 27);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(13, 111);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(39, 21);
            this.lblDNI.TabIndex = 19;
            this.lblDNI.Text = "Cuil";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 27);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNyA
            // 
            this.lblNyA.AutoSize = true;
            this.lblNyA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyA.Location = new System.Drawing.Point(10, 46);
            this.lblNyA.Name = "lblNyA";
            this.lblNyA.Size = new System.Drawing.Size(73, 21);
            this.lblNyA.TabIndex = 18;
            this.lblNyA.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Usuario";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NyA,
            this.CUIL});
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            
            this.dgvUsuarios.Size = new System.Drawing.Size(418, 425);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // NyA
            // 
            this.NyA.DataPropertyName = "nya";
            this.NyA.Frozen = true;
            this.NyA.HeaderText = "Nombre y Apellido";
            this.NyA.Name = "NyA";
            this.NyA.ReadOnly = true;
            this.NyA.Width = 220;
            // 
            // CUIL
            // 
            this.CUIL.DataPropertyName = "cuil";
            this.CUIL.Frozen = true;
            this.CUIL.HeaderText = "CUIL";
            this.CUIL.Name = "CUIL";
            this.CUIL.ReadOnly = true;
            this.CUIL.Width = 160;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(193, 439);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Usuario";
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
            this.btnModificar.Location = new System.Drawing.Point(3, 487);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(182, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Usuario";
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
            this.btnAgregar.Location = new System.Drawing.Point(3, 439);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerUsuario
            // 
            this.btnVerUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnVerUsuario.Image")));
            this.btnVerUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerUsuario.Location = new System.Drawing.Point(193, 486);
            this.btnVerUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerUsuario.Name = "btnVerUsuario";
            this.btnVerUsuario.Size = new System.Drawing.Size(182, 40);
            this.btnVerUsuario.TabIndex = 4;
            this.btnVerUsuario.Text = "Ver Usuario";
            this.btnVerUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerUsuario.UseVisualStyleBackColor = true;
            this.btnVerUsuario.Click += new System.EventHandler(this.btnVerUsuario_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnVerUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(825, 530);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.ComboBox cbxNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNyA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.MaskedTextBox txtCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NyA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIL;
    }
}
