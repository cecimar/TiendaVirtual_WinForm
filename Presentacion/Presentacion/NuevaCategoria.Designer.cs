namespace Presentacion
{
    partial class NuevaCategoria
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCategoriaNombre = new System.Windows.Forms.Label();
            this.lblCategoriaDescripcion = new System.Windows.Forms.Label();
            this.txtCategoriaNombre = new System.Windows.Forms.TextBox();
            this.txtCategoriaDescripcion = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblParametro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoriaNombre
            // 
            this.lblCategoriaNombre.AutoSize = true;
            this.lblCategoriaNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaNombre.Location = new System.Drawing.Point(9, 75);
            this.lblCategoriaNombre.Name = "lblCategoriaNombre";
            this.lblCategoriaNombre.Size = new System.Drawing.Size(182, 19);
            this.lblCategoriaNombre.TabIndex = 0;
            this.lblCategoriaNombre.Text = "Nombre Categoría (*):";
            this.lblCategoriaNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCategoriaDescripcion
            // 
            this.lblCategoriaDescripcion.AutoSize = true;
            this.lblCategoriaDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDescripcion.Location = new System.Drawing.Point(12, 124);
            this.lblCategoriaDescripcion.Name = "lblCategoriaDescripcion";
            this.lblCategoriaDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblCategoriaDescripcion.TabIndex = 1;
            this.lblCategoriaDescripcion.Text = "Descripción:";
            // 
            // txtCategoriaNombre
            // 
            this.txtCategoriaNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaNombre.Location = new System.Drawing.Point(256, 75);
            this.txtCategoriaNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoriaNombre.Name = "txtCategoriaNombre";
            this.txtCategoriaNombre.Size = new System.Drawing.Size(330, 27);
            this.txtCategoriaNombre.TabIndex = 2;
            this.txtCategoriaNombre.TextChanged += new System.EventHandler(this.txtCategoriaNombre_TextChanged);
            this.txtCategoriaNombre.Validated += new System.EventHandler(this.txtCategoriaNombre_Validated);
            // 
            // txtCategoriaDescripcion
            // 
            this.txtCategoriaDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaDescripcion.Location = new System.Drawing.Point(256, 124);
            this.txtCategoriaDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoriaDescripcion.Name = "txtCategoriaDescripcion";
            this.txtCategoriaDescripcion.Size = new System.Drawing.Size(330, 27);
            this.txtCategoriaDescripcion.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(176, 184);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(128, 37);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(310, 184);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(513, 9);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(85, 19);
            this.lblParametro.TabIndex = 20;
            this.lblParametro.Text = "Parametro";
            this.lblParametro.Visible = false;
            // 
            // NuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 256);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtCategoriaDescripcion);
            this.Controls.Add(this.txtCategoriaNombre);
            this.Controls.Add(this.lblCategoriaDescripcion);
            this.Controls.Add(this.lblCategoriaNombre);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Categoría";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NuevaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoriaNombre;
        private System.Windows.Forms.Label lblCategoriaDescripcion;
        private System.Windows.Forms.TextBox txtCategoriaNombre;
        private System.Windows.Forms.TextBox txtCategoriaDescripcion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.Label lblParametro;
    }
}

