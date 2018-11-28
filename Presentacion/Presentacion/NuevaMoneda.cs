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
            MessageBox.Show("Se creó la Moneda");
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
                    break;
                case "M":
                    this.Text = "Modificar Moneda";
                    break;
                case "E":
                    this.Text = "Eliminar Moneda";
                    break;
                default:
                    this.Text = "";
                    break;
            }
        }
    }
}
