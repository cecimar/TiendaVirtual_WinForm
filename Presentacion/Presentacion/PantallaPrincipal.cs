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
            frm.lblParametro.Text = "A";
            frm.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult SalirResultado;
            SalirResultado = MessageBox.Show("Está seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.OKCancel);
            if (SalirResultado==DialogResult.OK)
                Application.Exit();

        }


        private void nuevaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.lblParametro.Text = "A";
            frm.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProducto frm = new NuevoProducto();
            frm.lblParametro.Text = "A";
            frm.Show();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevoBackOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoBackOffice frm = new NuevoBackOffice();
            frm.lblParametro.Text = "A";
            frm.Show();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProducto frm = new NuevoProducto();
            frm.lblParametro.Text = "M";
            frm.Show();
        }

        private void modificarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.lblParametro.Text = "M";
            frm.Show();
        }

        private void modificarMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaMoneda frm = new NuevaMoneda();
            frm.lblParametro.Text = "M";
            frm.Show();
        }

        private void eliminarMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaMoneda frm = new NuevaMoneda();
            frm.lblParametro.Text = "E";
            frm.Show();
        }

        private void eliminarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.lblParametro.Text = "E";
            frm.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProducto frm = new NuevoProducto();
            frm.lblParametro.Text = "E";
            frm.Show();
        }

        private void modificarBackOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoBackOffice frm = new NuevoBackOffice();
            frm.lblParametro.Text = "M";
            frm.Show();
        }

        private void eliminarBackOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoBackOffice frm = new NuevoBackOffice();
            frm.lblParametro.Text = "E";
            frm.Show();
        }

        private void nuevoRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoRol frm = new NuevoRol();
            frm.lblParametro.Text = "A";
            frm.Show();
        }

        private void modificarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoRol frm = new NuevoRol();
            frm.lblParametro.Text = "M";
            frm.Show();
        }

        private void eliminarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoRol frm = new NuevoRol();
            frm.lblParametro.Text = "E";
            frm.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listarProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarObjeto frm = new ListarObjeto();
            frm.lblParametroListar.Text = "Producto";
            frm.Show();
        }

        private void listarBackOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarObjeto frm = new ListarObjeto();
            frm.lblParametroListar.Text = "BackOffice";
            frm.Show();
        }

        private void listarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarObjeto frm = new ListarObjeto();
            frm.lblParametroListar.Text = "Rol";
            frm.Show();
        }

        private void listarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarObjeto frm = new ListarObjeto();
            frm.lblParametroListar.Text = "Categoria";
            frm.Show();
        }

        private void listarMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarObjeto frm = new ListarObjeto();
            frm.lblParametroListar.Text = "Moneda";
            frm.Show();
        }

        private void monedasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfMonedas frm = new wfMonedas();
            frm.Show();
        }

        private void categoríasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfCategorias frm = new wfCategorias();
            frm.Show();
        }

        private void rolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfRol frm = new wfRol();
            frm.Show();
        }

        private void backOfficeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfBackOffice frm = new wfBackOffice();
            frm.Show();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfProductos frm = new wfProductos();
            frm.Show();
        }
    }
}
