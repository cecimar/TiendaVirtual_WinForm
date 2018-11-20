namespace Presentacion
{
    partial class NuevaMoneda
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtMonedaDescripcion = new System.Windows.Forms.TextBox();
            this.txtMonedaAbreviatura = new System.Windows.Forms.TextBox();
            this.lblCategoriaDescripcion = new System.Windows.Forms.Label();
            this.lblCategoriaNombre = new System.Windows.Forms.Label();
            this.txtMonedaCotizacion = new System.Windows.Forms.TextBox();
            this.lblMonedaCotizacion = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(349, 224);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 37);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(214, 224);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(128, 37);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtMonedaDescripcion
            // 
            this.txtMonedaDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedaDescripcion.Location = new System.Drawing.Point(269, 81);
            this.txtMonedaDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonedaDescripcion.Name = "txtMonedaDescripcion";
            this.txtMonedaDescripcion.Size = new System.Drawing.Size(330, 27);
            this.txtMonedaDescripcion.TabIndex = 9;
            this.txtMonedaDescripcion.Validated += new System.EventHandler(this.txtMonedaDescripcion_Validated);
            // 
            // txtMonedaAbreviatura
            // 
            this.txtMonedaAbreviatura.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedaAbreviatura.Location = new System.Drawing.Point(269, 32);
            this.txtMonedaAbreviatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonedaAbreviatura.Name = "txtMonedaAbreviatura";
            this.txtMonedaAbreviatura.Size = new System.Drawing.Size(330, 27);
            this.txtMonedaAbreviatura.TabIndex = 8;
            this.txtMonedaAbreviatura.Validated += new System.EventHandler(this.txtMonedaAbreviatura_Validated);
            // 
            // lblCategoriaDescripcion
            // 
            this.lblCategoriaDescripcion.AutoSize = true;
            this.lblCategoriaDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDescripcion.Location = new System.Drawing.Point(25, 81);
            this.lblCategoriaDescripcion.Name = "lblCategoriaDescripcion";
            this.lblCategoriaDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblCategoriaDescripcion.TabIndex = 7;
            this.lblCategoriaDescripcion.Text = "Descripción:";
            this.lblCategoriaDescripcion.Click += new System.EventHandler(this.lblCategoriaDescripcion_Click);
            // 
            // lblCategoriaNombre
            // 
            this.lblCategoriaNombre.AutoSize = true;
            this.lblCategoriaNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaNombre.Location = new System.Drawing.Point(22, 32);
            this.lblCategoriaNombre.Name = "lblCategoriaNombre";
            this.lblCategoriaNombre.Size = new System.Drawing.Size(191, 19);
            this.lblCategoriaNombre.TabIndex = 6;
            this.lblCategoriaNombre.Text = "Abreviatura Moneda(*):";
            this.lblCategoriaNombre.Click += new System.EventHandler(this.lblCategoriaNombre_Click);
            // 
            // txtMonedaCotizacion
            // 
            this.txtMonedaCotizacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedaCotizacion.Location = new System.Drawing.Point(269, 131);
            this.txtMonedaCotizacion.Name = "txtMonedaCotizacion";
            this.txtMonedaCotizacion.Size = new System.Drawing.Size(330, 27);
            this.txtMonedaCotizacion.TabIndex = 15;
            this.txtMonedaCotizacion.TextChanged += new System.EventHandler(this.txtMonedaCotizacion_TextChanged);
            this.txtMonedaCotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonedaCotizacion_KeyPress);
            this.txtMonedaCotizacion.Validated += new System.EventHandler(this.txtMonedaCotizacion_Validated);
            // 
            // lblMonedaCotizacion
            // 
            this.lblMonedaCotizacion.AutoSize = true;
            this.lblMonedaCotizacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaCotizacion.Location = new System.Drawing.Point(25, 131);
            this.lblMonedaCotizacion.Name = "lblMonedaCotizacion";
            this.lblMonedaCotizacion.Size = new System.Drawing.Size(122, 19);
            this.lblMonedaCotizacion.TabIndex = 14;
            this.lblMonedaCotizacion.Text = "Cotización (*):";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NuevaMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 299);
            this.Controls.Add(this.txtMonedaCotizacion);
            this.Controls.Add(this.lblMonedaCotizacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtMonedaDescripcion);
            this.Controls.Add(this.txtMonedaAbreviatura);
            this.Controls.Add(this.lblCategoriaDescripcion);
            this.Controls.Add(this.lblCategoriaNombre);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Moneda";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtMonedaDescripcion;
        private System.Windows.Forms.TextBox txtMonedaAbreviatura;
        private System.Windows.Forms.Label lblCategoriaDescripcion;
        private System.Windows.Forms.Label lblCategoriaNombre;
        private System.Windows.Forms.TextBox txtMonedaCotizacion;
        private System.Windows.Forms.Label lblMonedaCotizacion;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}