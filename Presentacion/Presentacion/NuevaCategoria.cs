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
            string catnom = "";
            TipoError err;
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
                    err=ws.InsertarCategoria(catvo);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se creó la Categoría");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la Categoría");
                    }
                    break;
                case "MC":
                    catid = Int32.Parse(this.txtCategoriaId.Text);
                    catnom = this.txtCategoriaNombre.Text;
                    err=ws.ModificarNombreCategoria(catid,catnom);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se modifico el nombre de la Categoría");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
                case "MD":
                    catid = Int32.Parse(this.txtCategoriaId.Text);
                    catdescr = this.txtCategoriaDescripcion.Text;
                    err=ws.ModificarDescripcionCategoria(catid, catdescr);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se modifico la descripcion de la Categoría");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
                case "E":
                    catid = Int32.Parse(this.txtCategoriaId.Text);
                    err=ws.BorrarCategoria(catid);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se elimino la Categoría");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString()); 
                    }
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
            //esto ya no se usa
            if (Int32.Parse(txtCategoriaId.Text) != 0)
            {
                WebServiceSoapClient ws = new WebServiceSoapClient();
                int catid = Int32.Parse(this.txtCategoriaId.Text);
                CategoriaVO catvo = new CategoriaVO();
                TipoError err = ws.DarCategoria(catid,out catvo);
                txtCategoriaDescripcion.Text = catvo.Descripcion;
                txtCategoriaNombre.Text = catvo.Nombre;
                chkCategoriaHabilitada.Checked = catvo.Habilitado;
            }
        }

        private void NuevaCategoria_Load_1(object sender, EventArgs e)
        {

        }
    }
}
