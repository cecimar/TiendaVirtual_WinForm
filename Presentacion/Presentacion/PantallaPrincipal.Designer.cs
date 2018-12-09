namespace Presentacion
{
    partial class PantallaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backOfficeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monedasToolStripMenuItem1,
            this.categoríasToolStripMenuItem1,
            this.rolToolStripMenuItem1,
            this.backOfficeToolStripMenuItem1,
            this.productoToolStripMenuItem1});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // monedasToolStripMenuItem1
            // 
            this.monedasToolStripMenuItem1.Name = "monedasToolStripMenuItem1";
            this.monedasToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.monedasToolStripMenuItem1.Text = "Monedas";
            this.monedasToolStripMenuItem1.Click += new System.EventHandler(this.monedasToolStripMenuItem1_Click);
            // 
            // categoríasToolStripMenuItem1
            // 
            this.categoríasToolStripMenuItem1.Name = "categoríasToolStripMenuItem1";
            this.categoríasToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.categoríasToolStripMenuItem1.Text = "Categorías";
            this.categoríasToolStripMenuItem1.Click += new System.EventHandler(this.categoríasToolStripMenuItem1_Click);
            // 
            // rolToolStripMenuItem1
            // 
            this.rolToolStripMenuItem1.Name = "rolToolStripMenuItem1";
            this.rolToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.rolToolStripMenuItem1.Text = "Rol";
            this.rolToolStripMenuItem1.Click += new System.EventHandler(this.rolToolStripMenuItem1_Click);
            // 
            // backOfficeToolStripMenuItem1
            // 
            this.backOfficeToolStripMenuItem1.Name = "backOfficeToolStripMenuItem1";
            this.backOfficeToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.backOfficeToolStripMenuItem1.Text = "BackOffice";
            this.backOfficeToolStripMenuItem1.Click += new System.EventHandler(this.backOfficeToolStripMenuItem1_Click);
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.productoToolStripMenuItem1.Text = "Producto";
            this.productoToolStripMenuItem1.Click += new System.EventHandler(this.productoToolStripMenuItem1_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda Virtual - Pantalla Principal";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backOfficeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
    }
}