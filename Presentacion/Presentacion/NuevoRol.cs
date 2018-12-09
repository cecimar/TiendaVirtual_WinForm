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
    public partial class NuevoRol : Form
    {
        public NuevoRol()
        {
            InitializeComponent();
        }

        private void NuevoRol_Load(object sender, EventArgs e)
        {
         
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int rolid = 0;
            string rolnom = "";
            WebServiceSoapClient ws = new WebServiceSoapClient();
            TipoError err;
            switch (lblParametro.Text)
            {
                case "A":
                    RolVO rolvo = new RolVO()
                    {
                        Nombre=this.txtRolNombre.Text
                    };
                    err=ws.InsertarRol(rolvo);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se creó el rol");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
                case "M":
                    rolid = Int32.Parse(this.txtRolId.Text);
                    rolnom = this.txtRolNombre.Text;
                    err=ws.ModificarRol(rolid, rolnom);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se modifico el rol");
                    }
                    else
                    {
                        MessageBox.Show(err.ToString());
                    }
                    break;
                case "E":
                    rolid = Int32.Parse(this.txtRolId.Text);
                    err=ws.BorrarRol(rolid);
                    if (err.ToString() == "Ok")
                    {
                        MessageBox.Show("Se elimino el rol");
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
            wfRol frm = new wfRol();
            frm.Show();
        }

        private void NuevoRol_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(txtRolId.Text) == 0)
            {
                errorProvider.SetError(txtRolId, "Debe ingresar el id del rol");
                txtRolId.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            wfRol frm = new wfRol();
            frm.Show();
        }
    }
}
