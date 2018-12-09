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
    public partial class wfCategorias : Form
    {
        public wfCategorias()
        {
            InitializeComponent();
        }


        private void wfCategorias_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            this.Text = "Listar Categorias";
            TipoError err = ws.ListarCategorias(out CategoriaVO[] lstcat);
            this.grdLista.DataSource = null;
            this.grdLista.DataSource = lstcat;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.Text = "Nueva Categoria";
            frm.lblParametro.Text = "A";
            frm.txtCategoriaId.Enabled = false;
            frm.txtCategoriaNombre.Enabled = true;
            frm.txtCategoriaDescripcion.Enabled = true;
            frm.chkCategoriaHabilitada.Enabled = true;
            frm.Show();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.lblParametro.Text = "MC";
            frm.Text = "Modificar Nombre Categoria";
            frm.txtCategoriaId.Enabled = false;
            frm.txtCategoriaNombre.Enabled = true;
            frm.txtCategoriaDescripcion.Enabled = false;
            frm.chkCategoriaHabilitada.Enabled = false;
            frm.txtCategoriaId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtCategoriaNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtCategoriaDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            if (grdLista.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                frm.chkCategoriaHabilitada.Checked = true;
            }
            else
            {
                frm.chkCategoriaHabilitada.Checked = false;
            }
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.lblParametro.Text = "E";
            frm.Text = "Eliminar Categoria";
            frm.txtCategoriaId.Enabled = false;
            frm.txtCategoriaNombre.Enabled = false;
            frm.txtCategoriaDescripcion.Enabled = false;
            frm.chkCategoriaHabilitada.Enabled = false;
            frm.txtCategoriaId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtCategoriaNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtCategoriaDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            if (grdLista.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                frm.chkCategoriaHabilitada.Checked = true;
            }
            else
            {
                frm.chkCategoriaHabilitada.Checked = false;
            }
            frm.Show();
        }

        private void btnModificarDescripcion_Click(object sender, EventArgs e)
        {
            NuevaCategoria frm = new NuevaCategoria();
            frm.lblParametro.Text = "MD";
            frm.txtCategoriaId.Enabled = false;
            frm.Text = "Modificar Descripcion Categoria";
            frm.txtCategoriaNombre.Enabled = false;
            frm.txtCategoriaDescripcion.Enabled = true;
            frm.chkCategoriaHabilitada.Enabled = false;
            frm.txtCategoriaId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtCategoriaNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtCategoriaDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            if (grdLista.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                frm.chkCategoriaHabilitada.Checked = true;
            }
            else
            {
                frm.chkCategoriaHabilitada.Checked = false;
            }
            frm.Show();
        }

        private void wfCategorias_Activated(object sender, EventArgs e)
        {
          
        }
    }
}
