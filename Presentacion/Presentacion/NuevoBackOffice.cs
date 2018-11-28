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
    public partial class NuevoBackOffice : Form
    {
        public NuevoBackOffice()
        {
            InitializeComponent();
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtProductoPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creó el Producto");
            this.Close();
        }

        private void txtUsuarioEmail_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioEmail.Text))
            {
                errorProvider.SetError(txtUsuarioEmail, "Debe ingresar un email");
                txtUsuarioEmail.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtUsuarioContrasenia_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioContrasenia.Text))
            {
                errorProvider.SetError(txtUsuarioContrasenia, "Debe ingresar un email");
                txtUsuarioContrasenia.Focus();
            }
            else
            {
                errorProvider.Clear();
            }

        }

        private void txtBackOfficeNombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBackOfficeNombre.Text))
            {
                errorProvider.SetError(txtBackOfficeNombre, "Debe ingresar un email");
                txtBackOfficeNombre.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void cmbRol_Validated(object sender, EventArgs e)
        {
            //hay que validar contra el enumerado que vamos a utilizar
        }

        private void txtUsuarioEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoBackOffice_Load(object sender, EventArgs e)
        {
            switch (lblParametro.Text)
            {
                case "A":
                    this.Text = "Nuevo BackOffice";
                    break;
                case "M":
                    this.Text = "Modificar BackOffice";
                    break;
                case "E":
                    this.Text = "Eliminar BackOffice";
                    break;
                default:
                    this.Text = "";
                    break;
            }
        }
    }
}
