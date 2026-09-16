using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Gestión_de_Catálogo
{
    public partial class FormArticulo : Form
    {
        private Articulo articulo = null;
        public FormArticulo()
        {
            InitializeComponent();
        }
        public FormArticulo(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
        }

        private void FormArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            if (articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;

                cbMarca.SelectedValue = articulo.IdMarca;
                cbCategoria.SelectedValue = articulo.IdCategoria;

                txtPrecio.Text = articulo.Precio.ToString();
            }

            cbMarca.DataSource = marcaNegocio.Listar();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";
            cbCategoria.DataSource = categoriaNegocio.Listar();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";

        }
    }
}
