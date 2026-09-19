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
        private List<Imagen> imagenes = new List<Imagen>();

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

                // Traemos las imagenes ya guardadas de este articulo.
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                imagenes = imagenNegocio.ListarPorArticulo(articulo.Id);
                CargarListaImagenes();
            }
        }

        private void CargarListaImagenes()
        {
            listBoxImagenes.Items.Clear();
            for (int i = 0; i < imagenes.Count; i++)
            {
                listBoxImagenes.Items.Add(imagenes[i].Url);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImagenUrl.Text))
            {
                MessageBox.Show("Ingrese una URL de imagen");
                return;
            }

            Imagen nueva = new Imagen();
            nueva.Url = txtImagenUrl.Text;

            imagenes.Add(nueva);
            CargarListaImagenes();

            txtImagenUrl.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal precio = decimal.Parse(txtPrecio.Text);

                bool esNuevo = (articulo == null);

                if (esNuevo)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.IdMarca = (int)cbMarca.SelectedValue;
                articulo.IdCategoria = (int)cbCategoria.SelectedValue;
                articulo.Precio = precio;

                ArticuloNegocio negocio = new ArticuloNegocio();

                if (esNuevo)
                {
                    articulo.Id = negocio.Agregar(articulo);
                }
                else
                {
                    negocio.Modificar(articulo);
                }

                // Guardamos solo las imagenes nuevas (las que todavia no tienen Id).
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                for (int i = 0; i < imagenes.Count; i++)
                {
                    if (imagenes[i].Id == 0)
                    {
                        imagenes[i].IdArticulo = articulo.Id;
                        imagenNegocio.Agregar(imagenes[i]);
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Revisa los datos ingresados (el precio debe ser un numero valido)");
            }
        }

        private void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}