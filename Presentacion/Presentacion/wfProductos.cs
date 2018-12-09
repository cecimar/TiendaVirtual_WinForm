using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.WebServiceTV;

namespace Presentacion
{
    public partial class wfProductos : Form
    {
        public wfProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wfProductos_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            this.Text = "Listar Productos";
            TipoError err = ws.ListarProductos(out ProductoVO[] lstprod);
            this.grdLista.DataSource = null;
            this.grdLista.DataSource = lstprod;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient wsr = new WebServiceSoapClient();
            NuevoProducto frm = new NuevoProducto();
            frm.Text = "Nuevo Producto";
            frm.lblParametro.Text = "A";
            TipoError err = wsr.ListarCategorias(out CategoriaVO[] lstcat);
            frm.cmbCategoria.DataSource = null;
            frm.cmbCategoria.DataSource = lstcat;
            frm.cmbCategoria.ValueMember = "IdCategoria";
            frm.cmbCategoria.DisplayMember = "Nombre";
            frm.txtProductoId.Enabled = false;
            frm.txtProductoNombre.Enabled = true;
            frm.txtProductoDescripcion.Enabled = true;
            frm.cmbCategoria.Enabled = true;
            frm.txtProductoPrecio.Enabled = true;
            frm.txtProductoStock.Enabled = true;
            frm.btnSubirFoto.Enabled = true;
            frm.chkProductoHabilitado.Enabled = true;
            this.Close();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient wsr = new WebServiceSoapClient();
            NuevoProducto frm = new NuevoProducto();
            frm.Text = "Eliminar Producto";
            frm.lblParametro.Text = "E";
            TipoError err = wsr.ListarCategorias(out CategoriaVO[] lstcat);
            frm.cmbCategoria.DataSource = null;
            frm.cmbCategoria.DataSource = lstcat;
            frm.cmbCategoria.ValueMember = "IdCategoria";
            frm.cmbCategoria.DisplayMember = "Nombre";
            frm.txtProductoId.Enabled = false;
            frm.txtProductoNombre.Enabled = false;
            frm.txtProductoDescripcion.Enabled = false;
            frm.cmbCategoria.Enabled = false;
            frm.txtProductoPrecio.Enabled = false;
            frm.txtProductoStock.Enabled = false;
            frm.btnSubirFoto.Enabled = false;
            frm.txtProductoId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtProductoNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtProductoDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            frm.cmbCategoria.SelectedValue = Int32.Parse(grdLista.CurrentRow.Cells[8].Value.ToString());
            frm.txtProductoPrecio.Text = grdLista.CurrentRow.Cells[4].Value.ToString();
            frm.txtProductoStock.Text = grdLista.CurrentRow.Cells[5].Value.ToString();
            string nomfoto = "c:\\FotosTiendaVirtual\\" + grdLista.CurrentRow.Cells[3].Value.ToString();
            frm.PicBoxProductoFoto.Image = Image.FromFile(nomfoto);
            if (grdLista.CurrentRow.Cells[7].Value.ToString() == "True")
            {
                frm.chkProductoHabilitado.Checked = true;
            }
            else
            {
                frm.chkProductoHabilitado.Checked = false;
            }

            this.Close();
            frm.Show();
        }

        private void btnModificarNombre_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient wsr = new WebServiceSoapClient();
            NuevoProducto frm = new NuevoProducto();
            frm.Text = "Modificar Producto";
            frm.lblParametro.Text = "MP";
            TipoError err = wsr.ListarCategorias(out CategoriaVO[] lstcat);
            frm.cmbCategoria.DataSource = null;
            frm.cmbCategoria.DataSource = lstcat;
            frm.cmbCategoria.ValueMember = "IdCategoria";
            frm.cmbCategoria.DisplayMember = "Nombre";
            frm.txtProductoId.Enabled = false;
            frm.txtProductoNombre.Enabled = true;
            frm.txtProductoDescripcion.Enabled = true;
            frm.cmbCategoria.Enabled = true;
            frm.txtProductoPrecio.Enabled = true;
            frm.txtProductoStock.Enabled = true;
            frm.btnSubirFoto.Enabled = true;
            frm.txtProductoId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtProductoNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtProductoDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            frm.cmbCategoria.SelectedValue = Int32.Parse(grdLista.CurrentRow.Cells[8].Value.ToString());
            frm.txtProductoPrecio.Text = grdLista.CurrentRow.Cells[4].Value.ToString();
            frm.txtProductoStock.Text = grdLista.CurrentRow.Cells[5].Value.ToString();
            string nomfoto = "c:\\FotosTiendaVirtual\\"+ grdLista.CurrentRow.Cells[3].Value.ToString();
            frm.PicBoxProductoFoto.Image = Image.FromFile(nomfoto);
            if (grdLista.CurrentRow.Cells[7].Value.ToString() == "True")
            {
                frm.chkProductoHabilitado.Checked = true;
            }
            else
            {
                frm.chkProductoHabilitado.Checked = false;
            }

            this.Close();
            frm.Show();
        }

        private void btnModificarStock_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient wsr = new WebServiceSoapClient();
            NuevoProducto frm = new NuevoProducto();
            frm.Text = "Modificar Stock";
            frm.lblParametro.Text = "MS";
            TipoError err = wsr.ListarCategorias(out CategoriaVO[] lstcat);
            frm.cmbCategoria.DataSource = null;
            frm.cmbCategoria.DataSource = lstcat;
            frm.cmbCategoria.ValueMember = "IdCategoria";
            frm.cmbCategoria.DisplayMember = "Nombre";
            frm.txtProductoId.Enabled = false;
            frm.txtProductoNombre.Enabled = false;
            frm.txtProductoDescripcion.Enabled = false;
            frm.cmbCategoria.Enabled = false;
            frm.txtProductoPrecio.Enabled = false;
            frm.txtProductoStock.Enabled = true;
            frm.btnSubirFoto.Enabled = false;
            frm.txtProductoId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtProductoNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtProductoDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            frm.cmbCategoria.SelectedValue = Int32.Parse(grdLista.CurrentRow.Cells[8].Value.ToString());
            frm.txtProductoPrecio.Text = grdLista.CurrentRow.Cells[4].Value.ToString();
            frm.txtProductoStock.Text = grdLista.CurrentRow.Cells[5].Value.ToString();
            string nomfoto = "c:\\FotosTiendaVirtual\\" + grdLista.CurrentRow.Cells[3].Value.ToString();
            frm.PicBoxProductoFoto.Image = Image.FromFile(nomfoto);
            if (grdLista.CurrentRow.Cells[7].Value.ToString() == "True")
            {
                frm.chkProductoHabilitado.Checked = true;
            }
            else
            {
                frm.chkProductoHabilitado.Checked = false;
            }

            this.Close();
            frm.Show();

            frm.Show();

        }
    }
}
