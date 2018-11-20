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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creó la Categoría");
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
    }
}
