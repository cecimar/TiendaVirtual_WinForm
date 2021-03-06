﻿namespace Presentacion
{
    partial class NuevoBackOffice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblBackOfficeNombre = new System.Windows.Forms.Label();
            this.txtBackOfficeNombre = new System.Windows.Forms.TextBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.txtUsuarioContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuarioEmail = new System.Windows.Forms.TextBox();
            this.lblUsuarioContrasenia = new System.Windows.Forms.Label();
            this.lblUsuarioEmail = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblParametro = new System.Windows.Forms.Label();
            this.chkBackOfficeHabilitado = new System.Windows.Forms.CheckBox();
            this.lblBackOfficeHabilitado = new System.Windows.Forms.Label();
            this.txtBackOfficeId = new System.Windows.Forms.TextBox();
            this.lblBackOfficeId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(356, 231);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(371, 27);
            this.cmbRol.TabIndex = 28;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            this.cmbRol.Validated += new System.EventHandler(this.cmbRol_Validated);
            // 
            // lblBackOfficeNombre
            // 
            this.lblBackOfficeNombre.AutoSize = true;
            this.lblBackOfficeNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackOfficeNombre.Location = new System.Drawing.Point(79, 182);
            this.lblBackOfficeNombre.Name = "lblBackOfficeNombre";
            this.lblBackOfficeNombre.Size = new System.Drawing.Size(106, 19);
            this.lblBackOfficeNombre.TabIndex = 27;
            this.lblBackOfficeNombre.Text = "Nombre (*): ";
            // 
            // txtBackOfficeNombre
            // 
            this.txtBackOfficeNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackOfficeNombre.Location = new System.Drawing.Point(356, 182);
            this.txtBackOfficeNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBackOfficeNombre.Name = "txtBackOfficeNombre";
            this.txtBackOfficeNombre.Size = new System.Drawing.Size(371, 27);
            this.txtBackOfficeNombre.TabIndex = 25;
            this.txtBackOfficeNombre.TextChanged += new System.EventHandler(this.txtProductoPrecio_TextChanged);
            this.txtBackOfficeNombre.Validated += new System.EventHandler(this.txtBackOfficeNombre_Validated);
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolNombre.Location = new System.Drawing.Point(79, 231);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(65, 19);
            this.lblRolNombre.TabIndex = 23;
            this.lblRolNombre.Text = "Rol (*):";
            // 
            // txtUsuarioContrasenia
            // 
            this.txtUsuarioContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioContrasenia.Location = new System.Drawing.Point(356, 133);
            this.txtUsuarioContrasenia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsuarioContrasenia.Name = "txtUsuarioContrasenia";
            this.txtUsuarioContrasenia.PasswordChar = '*';
            this.txtUsuarioContrasenia.Size = new System.Drawing.Size(371, 27);
            this.txtUsuarioContrasenia.TabIndex = 22;
            this.txtUsuarioContrasenia.Validated += new System.EventHandler(this.txtUsuarioContrasenia_Validated);
            // 
            // txtUsuarioEmail
            // 
            this.txtUsuarioEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioEmail.Location = new System.Drawing.Point(356, 86);
            this.txtUsuarioEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsuarioEmail.Name = "txtUsuarioEmail";
            this.txtUsuarioEmail.Size = new System.Drawing.Size(371, 27);
            this.txtUsuarioEmail.TabIndex = 21;
            this.txtUsuarioEmail.TextChanged += new System.EventHandler(this.txtUsuarioEmail_TextChanged);
            this.txtUsuarioEmail.Validated += new System.EventHandler(this.txtUsuarioEmail_Validated);
            // 
            // lblUsuarioContrasenia
            // 
            this.lblUsuarioContrasenia.AutoSize = true;
            this.lblUsuarioContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioContrasenia.Location = new System.Drawing.Point(79, 133);
            this.lblUsuarioContrasenia.Name = "lblUsuarioContrasenia";
            this.lblUsuarioContrasenia.Size = new System.Drawing.Size(135, 19);
            this.lblUsuarioContrasenia.TabIndex = 20;
            this.lblUsuarioContrasenia.Text = "Contraseña (*): ";
            // 
            // lblUsuarioEmail
            // 
            this.lblUsuarioEmail.AutoSize = true;
            this.lblUsuarioEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEmail.Location = new System.Drawing.Point(79, 86);
            this.lblUsuarioEmail.Name = "lblUsuarioEmail";
            this.lblUsuarioEmail.Size = new System.Drawing.Size(81, 19);
            this.lblUsuarioEmail.TabIndex = 19;
            this.lblUsuarioEmail.Text = "Email (*):";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(411, 327);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 44);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(259, 327);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(144, 44);
            this.btnGrabar.TabIndex = 29;
            this.btnGrabar.Text = "Aceptar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(686, 370);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(85, 19);
            this.lblParametro.TabIndex = 31;
            this.lblParametro.Text = "Parametro";
            this.lblParametro.Visible = false;
            // 
            // chkBackOfficeHabilitado
            // 
            this.chkBackOfficeHabilitado.AutoSize = true;
            this.chkBackOfficeHabilitado.Location = new System.Drawing.Point(356, 280);
            this.chkBackOfficeHabilitado.Name = "chkBackOfficeHabilitado";
            this.chkBackOfficeHabilitado.Size = new System.Drawing.Size(18, 17);
            this.chkBackOfficeHabilitado.TabIndex = 33;
            this.chkBackOfficeHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblBackOfficeHabilitado
            // 
            this.lblBackOfficeHabilitado.AutoSize = true;
            this.lblBackOfficeHabilitado.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackOfficeHabilitado.Location = new System.Drawing.Point(79, 280);
            this.lblBackOfficeHabilitado.Name = "lblBackOfficeHabilitado";
            this.lblBackOfficeHabilitado.Size = new System.Drawing.Size(93, 19);
            this.lblBackOfficeHabilitado.TabIndex = 32;
            this.lblBackOfficeHabilitado.Text = "Habilitado:";
            // 
            // txtBackOfficeId
            // 
            this.txtBackOfficeId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackOfficeId.Location = new System.Drawing.Point(356, 34);
            this.txtBackOfficeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBackOfficeId.Name = "txtBackOfficeId";
            this.txtBackOfficeId.Size = new System.Drawing.Size(371, 27);
            this.txtBackOfficeId.TabIndex = 35;
            this.txtBackOfficeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBackOfficeId_KeyPress);
            this.txtBackOfficeId.Validating += new System.ComponentModel.CancelEventHandler(this.txtBackOfficeId_Validating);
            // 
            // lblBackOfficeId
            // 
            this.lblBackOfficeId.AutoSize = true;
            this.lblBackOfficeId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackOfficeId.Location = new System.Drawing.Point(79, 34);
            this.lblBackOfficeId.Name = "lblBackOfficeId";
            this.lblBackOfficeId.Size = new System.Drawing.Size(118, 19);
            this.lblBackOfficeId.TabIndex = 34;
            this.lblBackOfficeId.Text = "BackOffice Id:";
            // 
            // NuevoBackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 398);
            this.Controls.Add(this.txtBackOfficeId);
            this.Controls.Add(this.lblBackOfficeId);
            this.Controls.Add(this.chkBackOfficeHabilitado);
            this.Controls.Add(this.lblBackOfficeHabilitado);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblBackOfficeNombre);
            this.Controls.Add(this.txtBackOfficeNombre);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.txtUsuarioContrasenia);
            this.Controls.Add(this.txtUsuarioEmail);
            this.Controls.Add(this.lblUsuarioContrasenia);
            this.Controls.Add(this.lblUsuarioEmail);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoBackOffice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo BackOffice";
            this.TopMost = true;
            //this.Load += new System.EventHandler(this.NuevoBackOffice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBackOfficeNombre;
        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Label lblUsuarioContrasenia;
        private System.Windows.Forms.Label lblUsuarioEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblBackOfficeHabilitado;
        private System.Windows.Forms.Label lblBackOfficeId;
        public System.Windows.Forms.ComboBox cmbRol;
        public System.Windows.Forms.TextBox txtBackOfficeNombre;
        public System.Windows.Forms.TextBox txtUsuarioContrasenia;
        public System.Windows.Forms.TextBox txtUsuarioEmail;
        public System.Windows.Forms.CheckBox chkBackOfficeHabilitado;
        public System.Windows.Forms.TextBox txtBackOfficeId;
    }
}