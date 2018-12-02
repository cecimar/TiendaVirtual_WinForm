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
            switch (lblParametro.Text)
            {
                case "A":
                    this.Text = "Nuevo Rol";
                    this.txtRolId.Enabled = false;
                    this.txtRolNombre.Enabled = true;
                    break;
                case "M":
                    this.Text = "Modificar Rol";
                    this.txtRolId.Enabled = true;
                    this.txtRolNombre.Enabled = true;
                    break;
                case "E":
                    this.Text = "Eliminar Rol";
                    this.txtRolId.Enabled = true;
                    this.txtRolNombre.Enabled = false;
                    break;
                default:
                    this.Text = "";
                    break;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int rolid = 0;
            string rolnom = "";
            WebServiceSoapClient ws = new WebServiceSoapClient();
            switch (lblParametro.Text)
            {
                case "A":
                    RolVO rolvo = new RolVO()
                    {
                        Nombre=this.txtRolNombre.Text
                    };
                    ws.InsertarRol(rolvo);
                    MessageBox.Show("Se creó el rol");
                    break;
                case "M":
                    rolid = Int32.Parse(this.txtRolId.Text);
                    rolnom = this.txtRolNombre.Text;
                    ws.ModificarRol(rolid, rolnom);
                    MessageBox.Show("Se modifico el rol");
                    break;
                case "E":
                    rolid = Int32.Parse(this.txtRolId.Text);
                    ws.BorrarRol(rolid);
                    MessageBox.Show("Se elimino el rol");
                    break;
                default:
                    this.Text = "";
                    break;
            }

            this.Close();
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
        }
    }
}
