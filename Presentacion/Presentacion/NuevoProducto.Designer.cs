namespace Presentacion
{
    partial class NuevoProducto
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
            this.txtProductoDescripcion = new System.Windows.Forms.TextBox();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.lblProductoDescripcion = new System.Windows.Forms.Label();
            this.lblProductoNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblProductoFoto = new System.Windows.Forms.Label();
            this.lblProductoPrecio = new System.Windows.Forms.Label();
            this.lblProductoStock = new System.Windows.Forms.Label();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.txtProductoStock = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.PicBoxProductoFoto = new System.Windows.Forms.PictureBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblParametro = new System.Windows.Forms.Label();
            this.chkProductoHabilitado = new System.Windows.Forms.CheckBox();
            this.lblProductoHabilitada = new System.Windows.Forms.Label();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.lblNombreFoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProductoFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoDescripcion.Location = new System.Drawing.Point(307, 117);
            this.txtProductoDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.Size = new System.Drawing.Size(330, 27);
            this.txtProductoDescripcion.TabIndex = 3;
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoNombre.Location = new System.Drawing.Point(307, 76);
            this.txtProductoNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(330, 27);
            this.txtProductoNombre.TabIndex = 2;
            this.txtProductoNombre.TextChanged += new System.EventHandler(this.txtProductoNombre_TextChanged);
            this.txtProductoNombre.Validated += new System.EventHandler(this.txtProductoNombre_Validated);
            // 
            // lblProductoDescripcion
            // 
            this.lblProductoDescripcion.AutoSize = true;
            this.lblProductoDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoDescripcion.Location = new System.Drawing.Point(61, 117);
            this.lblProductoDescripcion.Name = "lblProductoDescripcion";
            this.lblProductoDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblProductoDescripcion.TabIndex = 5;
            this.lblProductoDescripcion.Text = "Descripción:";
            // 
            // lblProductoNombre
            // 
            this.lblProductoNombre.AutoSize = true;
            this.lblProductoNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoNombre.Location = new System.Drawing.Point(61, 76);
            this.lblProductoNombre.Name = "lblProductoNombre";
            this.lblProductoNombre.Size = new System.Drawing.Size(179, 19);
            this.lblProductoNombre.TabIndex = 4;
            this.lblProductoNombre.Text = "Nombre Producto (*):";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(351, 493);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(216, 493);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(128, 37);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblProductoFoto
            // 
            this.lblProductoFoto.AutoSize = true;
            this.lblProductoFoto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoFoto.Location = new System.Drawing.Point(61, 298);
            this.lblProductoFoto.Name = "lblProductoFoto";
            this.lblProductoFoto.Size = new System.Drawing.Size(51, 19);
            this.lblProductoFoto.TabIndex = 10;
            this.lblProductoFoto.Text = "Foto:";
            // 
            // lblProductoPrecio
            // 
            this.lblProductoPrecio.AutoSize = true;
            this.lblProductoPrecio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoPrecio.Location = new System.Drawing.Point(61, 202);
            this.lblProductoPrecio.Name = "lblProductoPrecio";
            this.lblProductoPrecio.Size = new System.Drawing.Size(156, 19);
            this.lblProductoPrecio.TabIndex = 11;
            this.lblProductoPrecio.Text = "Precio Unitario (*):";
            // 
            // lblProductoStock
            // 
            this.lblProductoStock.AutoSize = true;
            this.lblProductoStock.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoStock.Location = new System.Drawing.Point(61, 246);
            this.lblProductoStock.Name = "lblProductoStock";
            this.lblProductoStock.Size = new System.Drawing.Size(171, 19);
            this.lblProductoStock.TabIndex = 12;
            this.lblProductoStock.Text = "Stock Disponible (*):";
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoPrecio.Location = new System.Drawing.Point(307, 202);
            this.txtProductoPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(330, 27);
            this.txtProductoPrecio.TabIndex = 5;
            this.txtProductoPrecio.Text = "0.0";
            this.txtProductoPrecio.TextChanged += new System.EventHandler(this.txtProductoPrecio_TextChanged);
            this.txtProductoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoPrecio_KeyPress);
            this.txtProductoPrecio.Validated += new System.EventHandler(this.txtProductoPrecio_Validated);
            // 
            // txtProductoStock
            // 
            this.txtProductoStock.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoStock.Location = new System.Drawing.Point(307, 246);
            this.txtProductoStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoStock.Name = "txtProductoStock";
            this.txtProductoStock.Size = new System.Drawing.Size(330, 27);
            this.txtProductoStock.TabIndex = 6;
            this.txtProductoStock.Text = "0";
            this.txtProductoStock.TextChanged += new System.EventHandler(this.txtProductoStock_TextChanged);
            this.txtProductoStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoStock_KeyPress);
            this.txtProductoStock.Validated += new System.EventHandler(this.txtProductoStock_Validated);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(61, 160);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(120, 19);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoría (*): ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirFoto.Location = new System.Drawing.Point(125, 293);
            this.btnSubirFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(156, 40);
            this.btnSubirFoto.TabIndex = 7;
            this.btnSubirFoto.Text = "Subir Foto";
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // PicBoxProductoFoto
            // 
            this.PicBoxProductoFoto.Location = new System.Drawing.Point(307, 293);
            this.PicBoxProductoFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicBoxProductoFoto.Name = "PicBoxProductoFoto";
            this.PicBoxProductoFoto.Size = new System.Drawing.Size(330, 127);
            this.PicBoxProductoFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxProductoFoto.TabIndex = 17;
            this.PicBoxProductoFoto.TabStop = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(307, 160);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(330, 27);
            this.cmbCategoria.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(552, 502);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(85, 19);
            this.lblParametro.TabIndex = 19;
            this.lblParametro.Text = "Parametro";
            this.lblParametro.Visible = false;
            // 
            // chkProductoHabilitado
            // 
            this.chkProductoHabilitado.AutoSize = true;
            this.chkProductoHabilitado.Location = new System.Drawing.Point(307, 445);
            this.chkProductoHabilitado.Name = "chkProductoHabilitado";
            this.chkProductoHabilitado.Size = new System.Drawing.Size(18, 17);
            this.chkProductoHabilitado.TabIndex = 8;
            this.chkProductoHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblProductoHabilitada
            // 
            this.lblProductoHabilitada.AutoSize = true;
            this.lblProductoHabilitada.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoHabilitada.Location = new System.Drawing.Point(61, 443);
            this.lblProductoHabilitada.Name = "lblProductoHabilitada";
            this.lblProductoHabilitada.Size = new System.Drawing.Size(93, 19);
            this.lblProductoHabilitada.TabIndex = 23;
            this.lblProductoHabilitada.Text = "Habilitado:";
            // 
            // txtProductoId
            // 
            this.txtProductoId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoId.Location = new System.Drawing.Point(307, 39);
            this.txtProductoId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(330, 27);
            this.txtProductoId.TabIndex = 1;
            this.txtProductoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoId_KeyPress);
            this.txtProductoId.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductoId_Validating);
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoId.Location = new System.Drawing.Point(60, 39);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(107, 19);
            this.lblProductoId.TabIndex = 25;
            this.lblProductoId.Text = "Producto Id:";
            // 
            // lblNombreFoto
            // 
            this.lblNombreFoto.AutoSize = true;
            this.lblNombreFoto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFoto.Location = new System.Drawing.Point(372, 424);
            this.lblNombreFoto.Name = "lblNombreFoto";
            this.lblNombreFoto.Size = new System.Drawing.Size(0, 16);
            this.lblNombreFoto.TabIndex = 26;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 543);
            this.Controls.Add(this.lblNombreFoto);
            this.Controls.Add(this.txtProductoId);
            this.Controls.Add(this.lblProductoId);
            this.Controls.Add(this.chkProductoHabilitado);
            this.Controls.Add(this.lblProductoHabilitada);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.PicBoxProductoFoto);
            this.Controls.Add(this.btnSubirFoto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtProductoStock);
            this.Controls.Add(this.txtProductoPrecio);
            this.Controls.Add(this.lblProductoStock);
            this.Controls.Add(this.lblProductoPrecio);
            this.Controls.Add(this.lblProductoFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtProductoDescripcion);
            this.Controls.Add(this.txtProductoNombre);
            this.Controls.Add(this.lblProductoDescripcion);
            this.Controls.Add(this.lblProductoNombre);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProductoFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductoDescripcion;
        private System.Windows.Forms.Label lblProductoNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblProductoFoto;
        private System.Windows.Forms.Label lblProductoPrecio;
        private System.Windows.Forms.Label lblProductoStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblProductoHabilitada;
        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.Label lblNombreFoto;
        public System.Windows.Forms.TextBox txtProductoDescripcion;
        public System.Windows.Forms.TextBox txtProductoNombre;
        public System.Windows.Forms.TextBox txtProductoPrecio;
        public System.Windows.Forms.TextBox txtProductoStock;
        public System.Windows.Forms.Button btnSubirFoto;
        public System.Windows.Forms.PictureBox PicBoxProductoFoto;
        public System.Windows.Forms.ComboBox cmbCategoria;
        public System.Windows.Forms.CheckBox chkProductoHabilitado;
        public System.Windows.Forms.TextBox txtProductoId;
    }
}