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
            frm.Show();
        }

        private void wfBackOffice_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            this.Text = "Listar BackOffice";
            TipoError err = ws.ListarBackoffice(out BackOfficeVO[] lstbo);
            this.grdLista.DataSource = null;
            this.grdLista.DataSource = lstbo;
        }
    }
