using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void listarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaMoneda frm = new NuevaMoneda();
            frm.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult SalirResultado;
            SalirResultado = MessageBox.Show("Está seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.OKCancel);
            if (SalirResultado==DialogResult.OK)
                Application.Exit();

        }

        private void monedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monedasToolStripMenuItem.Checked = !monedasToolStripMenuItem.Checked;
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoríasToolStripMenuItem.Checked = !categoríasToolStripMenuItem.Checked;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productoToolStripMenuItem.Checked = !productoToolStripMenuItem.Checked;
        }

        private void backOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backOfficeToolStripMenuItem.Checked=!backOfficeToolStripMenuItem.Checked;
        }

        private void nuevaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProducto frm = new NuevoProducto();
            frm.Show();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevoBackOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoBackOffice frm = new NuevoBackOffice();
            frm.Show();
        }
    }
}
