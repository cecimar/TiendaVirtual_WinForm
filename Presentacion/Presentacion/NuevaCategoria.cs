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
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int catid = 0;
            string catdescr = "";
            WebServiceSoapClient ws = new WebServiceSoapClient();
            switch (lblParametro.Text)
            {
                case "A":
                    CategoriaVO catvo = new CategoriaVO()
                    {
                        Nombre = this.txtCategoriaNombre.Text,
                        Descripcion = this.txtCategoriaDescripcion.Text,
                        Habilitado = this.chkCategoriaHabilitada.Checked
                    };
                    ws.InsertarCategoria(catvo);
                    MessageBox.Show("Se creó la Categoría");
                    break;
                case "M":
                    catid = Int32.Parse(this.txtCategoriaId.Text);
                    catdescr = this.txtCategoriaDescripcion.Text;
                    ws.ModificarDescripcionCategoria(catid, catdescr);
                    MessageBox.Show("Se modifico la Categoría");
                    break;
                case "E":
                    catid = Int32.Parse(this.txtCategoriaId.Text);
                    ws.BorrarCategoria(catid);
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
                    this.txtCategoriaId.Enabled = false;
                    this.txtCategoriaNombre.Enabled = true;
                    this.txtCategoriaDescripcion.Enabled = true;
                    this.chkCategoriaHabilitada.Enabled = true;
                    break;
                case "M":
                    this.Text = "Modificar Categoria";
                    this.txtCategoriaId.Enabled = true;
                    this.txtCategoriaNombre.Enabled = false;
                    this.txtCategoriaDescripcion.Enabled = true;
                    this.chkCategoriaHabilitada.Enabled = false;
                    break;
                case "E":
                    this.Text = "Eliminar Categoria";
                    this.txtCategoriaId.Enabled = true;
                    this.txtCategoriaNombre.Enabled = false;
                    this.txtCategoriaDescripcion.Enabled = false;
                    this.chkCategoriaHabilitada.Enabled = false;
                    break;
                default:
                    this.Text = "";
                    break;
            }
        }

        private void chkCategoriaHabilitada_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtCategoriaId_Enter(object sender, EventArgs e)
        {

        }

        private void txtCategoriaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permito ingresar solo un entero
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider.SetError(txtCategoriaId, "Solo se permite ingresar un valor entero");
                txtCategoriaId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtCategoriaId_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(txtCategoriaId.Text) == 0)
            {
                errorProvider.SetError(txtCategoriaId, "Debe ingresar el id de la categoria");
                txtCategoriaId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtCategoriaId_Validated(object sender, EventArgs e)
        {
            if (Int32.Parse(txtCategoriaId.Text) != 0)
            {
                WebServiceSoapClient ws = new WebServiceSoapClient();
                int catid = Int32.Parse(this.txtCategoriaId.Text);
                CategoriaVO catvo = ws.DarCategoria(catid);
                txtCategoriaDescripcion.Text = catvo.Descripcion;
                txtCategoriaNombre.Text = catvo.Nombre;
                chkCategoriaHabilitada.Checked = catvo.Habilitado;
            }
        }
    }
}
