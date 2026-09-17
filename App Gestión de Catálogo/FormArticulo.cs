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

            // Primero se cargan los combos con los datos de la base...
            cbMarca.DataSource = marcaNegocio.Listar();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";
            cbCategoria.DataSource = categoriaNegocio.Listar();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";

            // ...y recien despues se puede seleccionar un valor existente.
            if (articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;

                cbMarca.SelectedValue = articulo.IdMarca;
                cbCategoria.SelectedValue = articulo.IdCategoria;

                txtPrecio.Text = articulo.Precio.ToString();
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal precio = decimal.Parse(txtPrecio.Text);

                if (articulo == null)
                {
                    // Es un articulo nuevo
                    articulo = new Articulo();
                }

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.IdMarca = (int)cbMarca.SelectedValue;
                articulo.IdCategoria = (int)cbCategoria.SelectedValue;
                articulo.Precio = precio;

                ArticuloNegocio negocio = new ArticuloNegocio();

                if (articulo.Id == 0)
                {
                    negocio.Agregar(articulo);
                }
                else
                {
                    negocio.Modificar(articulo);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Revisa los datos ingresados (el precio debe ser un numero valido)");
            }
        }

       
    }
}