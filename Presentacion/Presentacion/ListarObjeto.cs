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
    public partial class ListarObjeto : Form
    {
        public ListarObjeto()
        {
            InitializeComponent();
        }

        private void txtProductoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductoNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            WebServiceSoapClient ws = new WebServiceSoapClient();
            switch (lblParametroListar.Text)
            {

                case "Producto":
                    this.Text = "Listar Producto";
                    List<ProductoVO> lstprod = new List<ProductoVO>();
                    lstprod = ws.ListarProductos().ToList();
                    this.grdLista.DataSource = null;
                    this.grdLista.DataSource = lstprod;
                    break;
                case "Moneda":
                    this.Text = "Listar Moneda";
                    List<MonedaVO> lstmon = new List<MonedaVO>();
                    lstmon = ws.ListarMonedas().ToList();
                    this.grdLista.DataSource = null;
                    this.grdLista.DataSource = lstmon;
                    break;
                case "Categoria":
                    this.Text = "Listar Categoria";
                    List<CategoriaVO> lstcat = new List<CategoriaVO>();
                    lstcat = ws.ListarCategorias().ToList();
                    this.grdLista.DataSource = null;
                    this.grdLista.DataSource = lstcat;
                    break;
                case "Rol":
                    this.Text = "Listar Rol";
                    List<RolVO> lstrol = new List<RolVO>();
                    lstrol = ws.ListarRoles().ToList();
                    this.grdLista.DataSource = null;
                    this.grdLista.DataSource = lstrol;
                    break;
                case "BackOffice":
                    this.Text = "Listar BackOffice";
                    List<BackofficeVO> lstbo = new List<BackofficeVO>();
                    lstbo = ws.ListarBackoffice().ToList();
                    this.grdLista.DataSource = null;
                    this.grdLista.DataSource = lstbo;
                    break;
                default:
                    this.Text = "";
                    break;
            }
        }
    }
}

