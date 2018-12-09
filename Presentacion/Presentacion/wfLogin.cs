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
    public partial class wfLogin : Form
    {
        public wfLogin()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            TipoError err=ws.UsuarioLoginWIN(this.txtUsuarioEmail.Text, this.txtUsuarioContrasenia.Text);
            if (err.ToString() == "Ok")
            {
                PantallaPrincipal frm = new PantallaPrincipal();
                frm.Show();
            }
            else
            {
                MessageBox.Show(err.ToString());
                this.txtUsuarioEmail.Text = "";
                this.txtUsuarioContrasenia.Text = "";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wfLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
