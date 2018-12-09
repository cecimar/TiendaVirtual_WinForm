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
    public partial class wfMonedas : Form
    {
        public wfMonedas()
        {
            InitializeComponent();
        }

        private void wfMonedas_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            this.Text = "Listar Moneda";
            TipoError err = ws.ListarMonedas(out MonedaVO[] lstmon);
            this.grdLista.DataSource = null;
            this.grdLista.DataSource = lstmon;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaMoneda frm = new NuevaMoneda();
            frm.lblParametro.Text = "A";
            frm.Text = "Nueva Moneda";
            frm.txtMonedaId.Enabled = false;
            frm.txtMonedaAbreviatura.Enabled = true;
            frm.txtMonedaDescripcion.Enabled = true;
            frm.txtMonedaCotizacion.Enabled = true;
            frm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NuevaMoneda frm = new NuevaMoneda();
            frm.lblParametro.Text = "M";
            frm.Text = "Modificar Moneda";
            frm.txtMonedaId.Enabled = false;
            frm.txtMonedaAbreviatura.Enabled = false;
            frm.txtMonedaDescripcion.Enabled = false;
            frm.txtMonedaCotizacion.Enabled = true;
            frm.txtMonedaId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtMonedaAbreviatura.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtMonedaDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            frm.txtMonedaCotizacion.Text = grdLista.CurrentRow.Cells[3].Value.ToString();
            this.Close();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NuevaMoneda frm = new NuevaMoneda();
            frm.lblParametro.Text = "E";
            frm.Text = "Eliminar Moneda";
            frm.txtMonedaId.Enabled = false;
            frm.txtMonedaAbreviatura.Enabled = false;
            frm.txtMonedaDescripcion.Enabled = false;
            frm.txtMonedaCotizacion.Enabled = false;
            frm.txtMonedaId.Text = grdLista.CurrentRow.Cells[0].Value.ToString();
            frm.txtMonedaAbreviatura.Text = grdLista.CurrentRow.Cells[1].Value.ToString();
            frm.txtMonedaDescripcion.Text = grdLista.CurrentRow.Cells[2].Value.ToString();
            frm.txtMonedaCotizacion.Text = grdLista.CurrentRow.Cells[3].Value.ToString();
            this.Close();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}