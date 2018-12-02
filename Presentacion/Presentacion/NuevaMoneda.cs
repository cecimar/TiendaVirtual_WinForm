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
    public partial class NuevaMoneda : Form
    {
        public NuevaMoneda()
        {
            InitializeComponent();
        }

        private void lblCategoriaNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (lblParametro.Text)
            {
                case "A":
                    MessageBox.Show("Se creó la Moneda");
                    break;
                case "M":
                    MessageBox.Show("Se modifico la Moneda");
                    break;
                case "E":
                    MessageBox.Show("Se elimino la Moneda");
                    break;
            }
           
            this.Close();
        }

        private void txtCategoriaDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCategoriaDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoriaNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonedaCotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 59) || (e.KeyChar == 8) || (e.KeyChar == 13)))
            {
                errorProvider.SetError(txtMonedaCotizacion, "Solo se permite ingresar un valor real");
                txtMonedaCotizacion.Focus();
            }
            else
            {
               errorProvider.Clear();
            }
        }

        private void txtMonedaCotizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonedaCotizacion_Validated(object sender, EventArgs e)
        {
          /*  if (float.Parse(txtMonedaCotizacion.Text) == 0)
            {
                errorProvider.SetError(txtMonedaCotizacion, "Debe ingresar una cotización de la Moneda");
                txtMonedaCotizacion.Focus();
            }
            else
            {
                errorProvider.Clear();
            }*/
        }

        private void txtMonedaAbreviatura_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonedaAbreviatura.Text))
            {
                errorProvider.SetError(txtMonedaAbreviatura, "Debe ingresar un nombre de Producto");
                txtMonedaAbreviatura.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtMonedaDescripcion_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonedaDescripcion.Text))
            {
                errorProvider.SetError(txtMonedaDescripcion, "Debe ingresar un nombre de Producto");
                txtMonedaDescripcion.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void NuevaMoneda_Load(object sender, EventArgs e)
        {
            switch (lblParametro.Text)
            {
                case "A":
                    this.Text = "Nueva Moneda";
                    this.txtMonedaId.Enabled = false;
                    this.txtMonedaAbreviatura.Enabled = true;
                    this.txtMonedaDescripcion.Enabled = true;
                    this.txtMonedaCotizacion.Enabled = true;
                    this.chkMonedaHabilitada.Enabled = true;
                    break;
                case "M":
                    this.Text = "Modificar Moneda";
                    this.txtMonedaId.Enabled = true;
                    this.txtMonedaAbreviatura.Enabled = true;
                    this.txtMonedaDescripcion.Enabled = true;
                    this.txtMonedaCotizacion.Enabled = true;
                    this.chkMonedaHabilitada.Enabled = true;
                    break;
                case "E":
                    this.Text = "Eliminar Moneda";
                    this.txtMonedaId.Enabled = true;
                    this.txtMonedaAbreviatura.Enabled = false;
                    this.txtMonedaDescripcion.Enabled = false;
                    this.txtMonedaCotizacion.Enabled = false;
                    this.chkMonedaHabilitada.Enabled = false;
                    break;
                default:
                    this.Text = "";
                    break;
            }
        }

        private void txtMonedaId_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(txtMonedaId.Text) == 0)
            {
                errorProvider.SetError(txtMonedaId, "Debe ingresar el id de la moneda");
                txtMonedaId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtMonedaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonedaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permito ingresar solo un entero
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider.SetError(txtMonedaId, "Solo se permite ingresar un valor entero");
                txtMonedaId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtMonedaCotizacion_Validating(object sender, CancelEventArgs e)
        {
            if (float.Parse(txtMonedaCotizacion.Text) == 0)
            {
                errorProvider.SetError(txtMonedaCotizacion, "Debe ingresar una cotización de la Moneda");
                txtMonedaCotizacion.Focus();
            }
            else
            {
                errorProvider.Clear();
            }

        }
    }
}
