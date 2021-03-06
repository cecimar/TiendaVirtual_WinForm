﻿namespace Presentacion
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
            this.lblParametro = new System.Windows.Forms.Label();
            this.txtMonedaId = new System.Windows.Forms.TextBox();
            this.lblMonedaId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(373, 251);
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
            this.btnGrabar.Location = new System.Drawing.Point(238, 251);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(128, 37);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Aceptar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtMonedaDescripcion
            // 
            this.txtMonedaDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedaDescripcion.Location = new System.Drawing.Point(293, 108);
            this.txtMonedaDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonedaDescripcion.Name = "txtMonedaDescripcion";
            this.txtMonedaDescripcion.Size = new System.Drawing.Size(330, 27);
            this.txtMonedaDescripcion.TabIndex = 3;
            this.txtMonedaDescripcion.Validated += new System.EventHandler(this.txtMonedaDescripcion_Validated);
            // 
            // txtMonedaAbreviatura
            // 
            this.txtMonedaAbreviatura.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedaAbreviatura.Location = new System.Drawing.Point(293, 59);
            this.txtMonedaAbreviatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonedaAbreviatura.Name = "txtMonedaAbreviatura";
            this.txtMonedaAbreviatura.Size = new System.Drawing.Size(330, 27);
            this.txtMonedaAbreviatura.TabIndex = 2;
            this.txtMonedaAbreviatura.Validated += new System.EventHandler(this.txtMonedaAbreviatura_Validated);
            // 
            // lblCategoriaDescripcion
            // 
            this.lblCategoriaDescripcion.AutoSize = true;
            this.lblCategoriaDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDescripcion.Location = new System.Drawing.Point(49, 108);
            this.lblCategoriaDescripcion.Name = "lblCategoriaDescripcion";
            this.lblCategoriaDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblCategoriaDescripcion.TabIndex = 7;
            this.lblCategoriaDescripcion.Text = "Descripción:";
            // 
            // lblCategoriaNombre
            // 
            this.lblCategoriaNombre.AutoSize = true;
            this.lblCategoriaNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaNombre.Location = new System.Drawing.Point(46, 59);
            this.lblCategoriaNombre.Name = "lblCategoriaNombre";
            this.lblCategoriaNombre.Size = new System.Drawing.Size(191, 19);
            this.lblCategoriaNombre.TabIndex = 6;
            this.lblCategoriaNombre.Text = "Abreviatura Moneda(*):";
            // 
            // txtMonedaCotizacion
            // 
            this.txtMonedaCotizacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedaCotizacion.Location = new System.Drawing.Point(293, 158);
            this.txtMonedaCotizacion.Name = "txtMonedaCotizacion";
            this.txtMonedaCotizacion.Size = new System.Drawing.Size(330, 27);
            this.txtMonedaCotizacion.TabIndex = 4;
            this.txtMonedaCotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonedaCotizacion_KeyPress);
            this.txtMonedaCotizacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonedaCotizacion_Validating);
            this.txtMonedaCotizacion.Validated += new System.EventHandler(this.txtMonedaCotizacion_Validated);
            // 
            // lblMonedaCotizacion
            // 
            this.lblMonedaCotizacion.AutoSize = true;
            this.lblMonedaCotizacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaCotizacion.Location = new System.Drawing.Point(49, 158);
            this.lblMonedaCotizacion.Name = "lblMonedaCotizacion";
            this.lblMonedaCotizacion.Size = new System.Drawing.Size(122, 19);
            this.lblMonedaCotizacion.TabIndex = 14;
            this.lblMonedaCotizacion.Text = "Cotización (*):";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(586, 262);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(85, 19);
            this.lblParametro.TabIndex = 21;
            this.lblParametro.Text = "Parametro";
            this.lblParametro.Visible = false;
            // 
            // txtMonedaId
            // 
            this.txtMonedaId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedaId.Location = new System.Drawing.Point(293, 13);
            this.txtMonedaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonedaId.Name = "txtMonedaId";
            this.txtMonedaId.Size = new System.Drawing.Size(330, 27);
            this.txtMonedaId.TabIndex = 1;
            this.txtMonedaId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonedaId_KeyPress);
            this.txtMonedaId.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonedaId_Validating);
            // 
            // lblMonedaId
            // 
            this.lblMonedaId.AutoSize = true;
            this.lblMonedaId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaId.Location = new System.Drawing.Point(46, 13);
            this.lblMonedaId.Name = "lblMonedaId";
            this.lblMonedaId.Size = new System.Drawing.Size(95, 19);
            this.lblMonedaId.TabIndex = 25;
            this.lblMonedaId.Text = "Moneda Id:";
            // 
            // NuevaMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 299);
            this.Controls.Add(this.txtMonedaId);
            this.Controls.Add(this.lblMonedaId);
            this.Controls.Add(this.lblParametro);
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
            this.Load += new System.EventHandler(this.NuevaMoneda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblCategoriaDescripcion;
        private System.Windows.Forms.Label lblCategoriaNombre;
        private System.Windows.Forms.Label lblMonedaCotizacion;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblMonedaId;
        public System.Windows.Forms.TextBox txtMonedaDescripcion;
        public System.Windows.Forms.TextBox txtMonedaAbreviatura;
        public System.Windows.Forms.TextBox txtMonedaCotizacion;
        public System.Windows.Forms.TextBox txtMonedaId;
    }
}