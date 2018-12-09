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
    public partial class wfBackOffice : Form
    {
        public wfBackOffice()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient wsr = new WebServiceSoapClient();
            NuevoBackOffice frm = new NuevoBackOffice();
            frm.Text = "Nuevo BackOffice";
            frm.lblParametro.Text = "A";
            TipoError err = wsr.ListarRoles(out RolVO[] lstrol);
            frm.cmbRol.DataSource = null;
            frm.cmbRol.DataSource = lstrol;
            frm.cmbRol.ValueMember = "IdRol";
            frm.cmbRol.DisplayMember = "Nombre";
            frm.txtBackOfficeId.Enabled = false;
            frm.txtUsuarioEmail.Enabled = true;
            frm.txtUsuarioContrasenia.Enabled = true;
            frm.txtBackOfficeNombre.Enabled = true;
            frm.cmbRol.Enabled = true;
            this.Close();
            frm.Show();
        }

        private void wfBackOffice_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            this.Text = "Listar BackOffice";
            TipoError err = ws.ListarBackoffice(out BackofficeVO[] lstbo);
            this.grdLista.DataSource = null;
            this.grdLista.DataSource = lstbo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NuevoBackOffice frm = new NuevoBackOffice();
            frm.Text = "Nuevo BackOffice";
            frm.lblParametro.Text = "E";
            frm.txtBackOfficeId.Enabled = false;
            frm.txtUsuarioEmail.Enabled = false;
            frm.txtUsuarioContrasenia.Enabled = false;
            frm.txtBackOfficeNombre.Enabled = false;
            frm.cmbRol.Enabled = false;
            frm.txtBackOfficeId.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            frm.txtUsuarioEmail.Text = grdLista.CurrentRow.Cells[3].Value.ToString();
            frm.txtUsuarioContrasenia.Text = grdLista.CurrentRow.Cells[4].Value.ToString();
            frm.txtBackOfficeNombre.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.cmbRol.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            if (grdLista.CurrentRow.Cells[5].Value.ToString() == "True")
            {
                frm.chkBackOfficeHabilitado.Checked = true;
            }
            else
            {
                frm.chkBackOfficeHabilitado.Checked = false;
            }
            this.Close();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
