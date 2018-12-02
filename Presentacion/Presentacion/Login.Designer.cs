namespace Presentacion
{
    partial class frmLogin
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtUsuarioContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuarioEmail = new System.Windows.Forms.TextBox();
            this.lblUsuarioContrasenia = new System.Windows.Forms.Label();
            this.lblUsuarioEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(419, 158);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 44);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(267, 158);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(144, 44);
            this.btnGrabar.TabIndex = 35;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtUsuarioContrasenia
            // 
            this.txtUsuarioContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioContrasenia.Location = new System.Drawing.Point(327, 81);
            this.txtUsuarioContrasenia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsuarioContrasenia.Name = "txtUsuarioContrasenia";
            this.txtUsuarioContrasenia.PasswordChar = '*';
            this.txtUsuarioContrasenia.Size = new System.Drawing.Size(371, 27);
            this.txtUsuarioContrasenia.TabIndex = 34;
            // 
            // txtUsuarioEmail
            // 
            this.txtUsuarioEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioEmail.Location = new System.Drawing.Point(327, 34);
            this.txtUsuarioEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsuarioEmail.Name = "txtUsuarioEmail";
            this.txtUsuarioEmail.Size = new System.Drawing.Size(371, 27);
            this.txtUsuarioEmail.TabIndex = 33;
            // 
            // lblUsuarioContrasenia
            // 
            this.lblUsuarioContrasenia.AutoSize = true;
            this.lblUsuarioContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioContrasenia.Location = new System.Drawing.Point(50, 81);
            this.lblUsuarioContrasenia.Name = "lblUsuarioContrasenia";
            this.lblUsuarioContrasenia.Size = new System.Drawing.Size(135, 19);
            this.lblUsuarioContrasenia.TabIndex = 32;
            this.lblUsuarioContrasenia.Text = "Contraseña (*): ";
            // 
            // lblUsuarioEmail
            // 
            this.lblUsuarioEmail.AutoSize = true;
            this.lblUsuarioEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEmail.Location = new System.Drawing.Point(50, 34);
            this.lblUsuarioEmail.Name = "lblUsuarioEmail";
            this.lblUsuarioEmail.Size = new System.Drawing.Size(81, 19);
            this.lblUsuarioEmail.TabIndex = 31;
            this.lblUsuarioEmail.Text = "Email (*):";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 229);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtUsuarioContrasenia);
            this.Controls.Add(this.txtUsuarioEmail);
            this.Controls.Add(this.lblUsuarioContrasenia);
            this.Controls.Add(this.lblUsuarioEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtUsuarioContrasenia;
        private System.Windows.Forms.TextBox txtUsuarioEmail;
        private System.Windows.Forms.Label lblUsuarioContrasenia;
        private System.Windows.Forms.Label lblUsuarioEmail;
    }
}