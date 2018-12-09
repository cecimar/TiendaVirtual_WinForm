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
    public partial class NuevoProducto : Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();

            //Cargo el combo con los roles
            //List<CategoriaVO> lstcat = new List<CategoriaVO>();
            TipoError err = ws.ListarCategorias(out CategoriaVO[] lstcat);
            this.cmbCategoria.DataSource = null;
            this.cmbCategoria.DataSource = lstcat;
            this.cmbCategoria.ValueMember = "IdCategoria";
            this.cmbCategoria.DisplayMember = "Nombre";

            //Identifico el parametro que se paso
            switch (lblParametro.Text)
            {
                case "A":
                    this.Text = "Nuevo Producto";
                    this.txtProductoId.Enabled = false;
                    this.txtProductoNombre.Enabled = true;
                    this.txtProductoDescripcion.Enabled = true;
                    this.cmbCategoria.Enabled = true;
                    this.txtProductoPrecio.Enabled = true;
                    this.txtProductoStock.Enabled = true;
                    this.btnSubirFoto.Enabled = true;
                    break;
                case "M":
                    this.Text = "Modificar Producto";
                    this.txtProductoId.Enabled = true;
                    this.txtProductoNombre.Enabled = true;
                    this.txtProductoDescripcion.Enabled = true;
                    this.cmbCategoria.Enabled = true;
                    this.txtProductoPrecio.Enabled = true;
                    this.txtProductoStock.Enabled = true;
                    this.btnSubirFoto.Enabled = true;
                    break;
                case "E":
                    this.Text = "Eliminar Producto";
                    this.txtProductoId.Enabled = true;
                    this.txtProductoNombre.Enabled = false;
                    this.txtProductoDescripcion.Enabled = false;
                    this.cmbCategoria.Enabled = false;
                    this.txtProductoPrecio.Enabled = false;
                    this.txtProductoStock.Enabled = false;
                    this.btnSubirFoto.Enabled = false;
                    break;
                default:
                    this.Text = "";
                    break;
            }
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int proid;
            WebServiceSoapClient ws = new WebServiceSoapClient();
           
            switch (lblParametro.Text)
            {
                case "A":
                    ProductoVO prvo = new ProductoVO()
                    {
                        Nombre = this.txtProductoNombre.Text,
                        Descripcion = this.txtProductoDescripcion.Text,
                        IdCategoria = (int)this.cmbCategoria.SelectedValue,
                        Precio = Decimal.Parse(this.txtProductoPrecio.Text),
                        Stock = Int32.Parse(this.txtProductoStock.Text),
                        Foto = this.lblNombreFoto.Text,
                        FechaAlta = DateTime.Today,
                        Habilitado = this.chkProductoHabilitado.Checked
                    };

                    ws.InsertarProducto(prvo);
                    MessageBox.Show("Se creó el Producto");
                    break;
                case "M":
                    //ws.ModificarProducto();
                    MessageBox.Show("Aun no implementado");
                    break;
                case "E":
                    proid = Int32.Parse(this.txtProductoId.Text);
                    ws.BorrarProducto(proid);
                    MessageBox.Show("Se elimino el Producto");
                    break;
            }
            this.Close();
        }
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    lblNombreFoto.Text = openFileDialog1.SafeFileName;
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
            if (float.Parse(txtProductoStock.Text) == 0)
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
            //Permito ingresar solo un entero
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider.SetError(txtProductoStock, "Solo se permite ingresar un valor entero");
                txtProductoStock.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtProductoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permito ingresar solo un real
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

        private void txtProductoStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductoId_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(txtProductoId.Text) == 0)
            {
                errorProvider.SetError(txtProductoId, "Debe ingresar el id del Producto");
                txtProductoId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }

        }

        private void txtProductoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permito ingresar solo un entero
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider.SetError(txtProductoId, "Solo se permite ingresar un valor entero");
                txtProductoId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }

        }
    }
}
