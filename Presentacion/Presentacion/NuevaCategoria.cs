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
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (lblParametro.Text)
            {
                case "A":
                    MessageBox.Show("Se creó la Categoría");
                    break;
                case "M":
                    MessageBox.Show("Se modifico la Categoría");
                    break;
                case "E":
                    MessageBox.Show("Se elimino la Categoría");
                    break;
                default:
                    this.Text = "";
                    break;
            }
            
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCategoriaNombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoriaNombre.Text))
            {
                errorProvider.SetError(txtCategoriaNombre, "Debe ingresar un nombre de Categoría");
                txtCategoriaNombre.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtCategoriaNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblParametro_Click(object sender, EventArgs e)
        {

        }

        private void NuevaCategoria_Load(object sender, EventArgs e)
        {
            switch (lblParametro.Text)
            {
                case "A":
                    this.Text = "Nueva Categoria";
                    break;
                case "M":
                    this.Text = "Modificar Categoria";
                    break;
                case "E":
                    this.Text = "Eliminar Categoria";
                    break;
                default:
                    this.Text = "";
                    break;
            }
        }
    }
}
