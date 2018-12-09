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
    public partial class NuevoBackOffice : Form
    {
        public NuevoBackOffice()
        {
            InitializeComponent();
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
            int boid;
            WebServiceSoapClient ws = new WebServiceSoapClient();
            TipoError err;

            switch (lblParametro.Text)
            {
                case "A":
                    BackofficeInsVO bovo = new BackofficeInsVO
                    {
                        Email = this.txtUsuarioEmail.Text,
                        Password = this.txtUsuarioContrasenia.Text,
                        Nombre = this.txtBackOfficeNombre.Text,
                        RolId = (int)this.cmbRol.SelectedValue,
                        Activo = this.chkBackOfficeHabilitado.Checked,
                        TipoUsuario = "backoffice"
                    };
                    err=ws.InsertarBackoffice(bovo);
                    if (err.ToString()=="Ok")
                    {
                        MessageBox.Show("Se creo el BackOffice");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;

                case "M":

                    MessageBox.Show("Se modifico BO");
                    break;
                case "E":
                    boid = Int32.Parse(this.txtBackOfficeId.Text);
                    err=ws.BorrarBackoffice(boid);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se elimino el BackOffice");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
            }
            
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
            
        }

        private void txtUsuarioEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoBackOffice_Load(object sender, EventArgs e)
        {
            //Identifico el modo que se paso por parametro
            WebServiceSoapClient ws = new WebServiceSoapClient();

            //Cargo el combo con los roles
            //List<RolVO> lstrol = new List<RolVO>();
            TipoError err = ws.ListarRoles(out RolVO[] lstrol);
            this.cmbRol.DataSource = null;
            this.cmbRol.DataSource = lstrol;
            this.cmbRol.ValueMember = "IdRol";
            this.cmbRol.DisplayMember = "Nombre";

            switch (lblParametro.Text)
            {
               
                case "M":
                    this.Text = "Modificar BackOffice";
                    this.txtBackOfficeId.Enabled = true;
                    this.txtUsuarioEmail.Enabled = false;
                    this.txtUsuarioContrasenia.Enabled = true;
                    this.txtBackOfficeNombre.Enabled = true;
                    this.cmbRol.Enabled = true;
                    break;
                case "E":
                    this.Text = "Eliminar BackOffice";
                    this.txtBackOfficeId.Enabled = true;
                    this.txtUsuarioEmail.Enabled = false;
                    this.txtUsuarioContrasenia.Enabled = false;
                    this.txtBackOfficeNombre.Enabled = false;
                    this.cmbRol.Enabled = false;
                    break;
                default:
                    this.Text = "";
                    break;
            }
          
        }

        private void txtBackOfficeId_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(txtBackOfficeId.Text) == 0)
            {
                errorProvider.SetError(txtBackOfficeId, "Debe ingresar el id del BackOffice");
                txtBackOfficeId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtBackOfficeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permito ingresar solo un entero
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider.SetError(txtBackOfficeId, "Solo se permite ingresar un valor entero");
                txtBackOfficeId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
