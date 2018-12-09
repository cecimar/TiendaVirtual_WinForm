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
            this.lblCategoriaHabilitada = new System.Windows.Forms.Label();
            this.chkCategoriaHabilitada = new System.Windows.Forms.CheckBox();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.lblCategoriaId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoriaNombre
            // 
            this.lblCategoriaNombre.AutoSize = true;
            this.lblCategoriaNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaNombre.Location = new System.Drawing.Point(14, 59);
            this.lblCategoriaNombre.Name = "lblCategoriaNombre";
            this.lblCategoriaNombre.Size = new System.Drawing.Size(182, 19);
            this.lblCategoriaNombre.TabIndex = 0;
            this.lblCategoriaNombre.Text = "Nombre Categoría (*):";
            // 
            // lblCategoriaDescripcion
            // 
            this.lblCategoriaDescripcion.AutoSize = true;
            this.lblCategoriaDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDescripcion.Location = new System.Drawing.Point(17, 108);
            this.lblCategoriaDescripcion.Name = "lblCategoriaDescripcion";
            this.lblCategoriaDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblCategoriaDescripcion.TabIndex = 1;
            this.lblCategoriaDescripcion.Text = "Descripción:";
            // 
            // txtCategoriaNombre
            // 
            this.txtCategoriaNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaNombre.Location = new System.Drawing.Point(261, 59);
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
            this.txtCategoriaDescripcion.Location = new System.Drawing.Point(261, 108);
            this.txtCategoriaDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoriaDescripcion.Name = "txtCategoriaDescripcion";
            this.txtCategoriaDescripcion.Size = new System.Drawing.Size(330, 27);
            this.txtCategoriaDescripcion.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(176, 206);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(128, 37);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Aceptar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(310, 206);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 37);
            this.btnCancelar.TabIndex = 6;
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
            this.lblParametro.Location = new System.Drawing.Point(506, 224);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(85, 19);
            this.lblParametro.TabIndex = 20;
            this.lblParametro.Text = "Parametro";
            this.lblParametro.Visible = false;
            // 
            // lblCategoriaHabilitada
            // 
            this.lblCategoriaHabilitada.AutoSize = true;
            this.lblCategoriaHabilitada.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaHabilitada.Location = new System.Drawing.Point(17, 157);
            this.lblCategoriaHabilitada.Name = "lblCategoriaHabilitada";
            this.lblCategoriaHabilitada.Size = new System.Drawing.Size(93, 19);
            this.lblCategoriaHabilitada.TabIndex = 21;
            this.lblCategoriaHabilitada.Text = "Habilitado:";
            // 
            // chkCategoriaHabilitada
            // 
            this.chkCategoriaHabilitada.AutoSize = true;
            this.chkCategoriaHabilitada.Location = new System.Drawing.Point(261, 154);
            this.chkCategoriaHabilitada.Name = "chkCategoriaHabilitada";
            this.chkCategoriaHabilitada.Size = new System.Drawing.Size(18, 17);
            this.chkCategoriaHabilitada.TabIndex = 4;
            this.chkCategoriaHabilitada.UseVisualStyleBackColor = true;
            this.chkCategoriaHabilitada.CheckedChanged += new System.EventHandler(this.chkCategoriaHabilitada_CheckedChanged);
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaId.Location = new System.Drawing.Point(261, 13);
            this.txtCategoriaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.Size = new System.Drawing.Size(330, 27);
            this.txtCategoriaId.TabIndex = 1;
            this.txtCategoriaId.Enter += new System.EventHandler(this.txtCategoriaId_Enter);
            this.txtCategoriaId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoriaId_KeyPress);
            this.txtCategoriaId.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoriaId_Validating);
            this.txtCategoriaId.Validated += new System.EventHandler(this.txtCategoriaId_Validated);
            // 
            // lblCategoriaId
            // 
            this.lblCategoriaId.AutoSize = true;
            this.lblCategoriaId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaId.Location = new System.Drawing.Point(14, 13);
            this.lblCategoriaId.Name = "lblCategoriaId";
            this.lblCategoriaId.Size = new System.Drawing.Size(110, 19);
            this.lblCategoriaId.TabIndex = 23;
            this.lblCategoriaId.Text = "Categoría Id:";
            // 
            // NuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 256);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.lblCategoriaId);
            this.Controls.Add(this.chkCategoriaHabilitada);
            this.Controls.Add(this.lblCategoriaHabilitada);
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
            this.Load += new System.EventHandler(this.NuevaCategoria_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoriaNombre;
        private System.Windows.Forms.Label lblCategoriaDescripcion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblCategoriaHabilitada;
        private System.Windows.Forms.Label lblCategoriaId;
        public System.Windows.Forms.TextBox txtCategoriaNombre;
        public System.Windows.Forms.TextBox txtCategoriaDescripcion;
        public System.Windows.Forms.CheckBox chkCategoriaHabilitada;
        public System.Windows.Forms.TextBox txtCategoriaId;
    }
}

