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
    public partial class NuevaMoneda : Form
    {
        public NuevaMoneda()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int monid = 0;
            decimal moncot = 0;
            WebServiceSoapClient ws = new WebServiceSoapClient();
            TipoError err;
            switch (lblParametro.Text)
            {
                case "A":
                    MonedaVO monvo = new MonedaVO()
                    {
                        Abreviatura = this.txtMonedaAbreviatura.Text,
                        Descripcion = this.txtMonedaDescripcion.Text,
                        Cotizacion = Decimal.Parse(txtMonedaCotizacion.Text)
                    };
                    err=ws.InsertarMoneda(monvo);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se creo la Moneda");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
                case "M":
                    monid = Int32.Parse(this.txtMonedaId.Text);
                    moncot = Decimal.Parse(this.txtMonedaCotizacion.Text);
                    err=ws.ModificarMonedaCotizacion(monid, moncot);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se modifico la cotizacion de la moneda");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
                case "E":
                    monid = Int32.Parse(this.txtMonedaId.Text);
                    err=ws.BorrarMoneda(monid);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se elimino la Moneda");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
            }
           
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void txtMonedaId_Validating(object sender, CancelEventArgs e)
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

        public void txtMonedaId_KeyPress(object sender, KeyPressEventArgs e)
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
            if (Decimal.Parse(txtMonedaCotizacion.Text) == 0)
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
