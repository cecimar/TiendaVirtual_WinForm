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
    public partial class wfRol : Form
    {
        public wfRol()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoRol frm = new NuevoRol();
            frm.lblParametro.Text = "A";
            frm.Text = "Nuevo Rol";
            frm.txtRolId.Enabled = false;
            frm.txtRolNombre.Enabled = true;
            this.Close();
            frm.Show();
        }

        private void btnModificarNombre_Click(object sender, EventArgs e)
        {
            NuevoRol frm = new NuevoRol();
            frm.lblParametro.Text = "M";
            frm.Text = "Modificar Rol";
            frm.txtRolId.Enabled = false;
            frm.txtRolNombre.Enabled = true;
            frm.txtRolId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtRolNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            this.Close();
            frm.Show();     
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NuevoRol frm = new NuevoRol();
            frm.lblParametro.Text = "E";
            frm.Text = "Eliminar Rol";
            frm.txtRolId.Enabled = false;
            frm.txtRolNombre.Enabled = false;
            frm.txtRolId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtRolNombre.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            this.Close();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wfRol_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            this.Text = "Listar Roles";
            TipoError err = ws.ListarRoles(out RolVO[] lstrol);
            this.grdLista.DataSource = null;
            this.grdLista.DataSource = lstrol;
        }
    }
}
