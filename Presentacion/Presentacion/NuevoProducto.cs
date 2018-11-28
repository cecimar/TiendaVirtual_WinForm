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
    public partial class NuevoProducto : Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            switch (lblParametro.Text)
            {
                case "A":
                    this.Text = "Nuevo Producto";
                    break;
                case "M":
                    this.Text = "Modificar Producto";
                    break;
                default:
                    this.Text = "";
                    break;
            }
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creó el Producto");
            this.Close();
        }
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblProductoPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblProductoFoto_Click(object sender, EventArgs e)
        {

        }

        private void txtProductoPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    PicBoxProductoFoto.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido","Validación de datos");
            }
        }

        private void txtProductoNombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductoNombre.Text))
            {
                errorProvider.SetError(txtProductoNombre, "Debe ingresar un nombre de Producto");
                txtProductoNombre.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtProductoPrecio_Validated(object sender, EventArgs e)
        {
           if (float.Parse(txtProductoPrecio.Text) == 0)
            {
                errorProvider.SetError(txtProductoPrecio, "Debe ingresar un precio al Producto");
                txtProductoPrecio.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtProductoStock_Validated(object sender, EventArgs e)
        {
            if (Int32.Parse(txtProductoStock.Text) == 0)
            {
                errorProvider.SetError(txtProductoPrecio, "Debe ingresar el stock actual del Producto");
                txtProductoPrecio.Focus();
            }
            else
            {
                errorProvider.Clear();
            }

        }

        private void txtProductoStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider.SetError(txtProductoStock, "Solo se permite ingresar un valor numérico");
                txtProductoStock.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtProductoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 59) || (e.KeyChar == 8) || (e.KeyChar == 13)))
            {
                errorProvider.SetError(txtProductoPrecio, "Solo se permite ingresar un valor real");
                txtProductoPrecio.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtProductoNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
