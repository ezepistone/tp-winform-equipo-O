using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace App_Gestión_de_Catálogo
{
    public partial class FormDetalleArticulo : Form
    {
        private Articulo articulo;
        private List<Imagen> imagenes;
        private int indiceimagenActual = 0;

        public FormDetalleArticulo(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
        }

        private void FormDetalleArticulo_Load(object sender, EventArgs e)
        {
            // Cargar los detalles del artículo en los controles del formulario
            lblValorCodigo.Text = articulo.Codigo;
            lblValorNombre.Text = articulo.Nombre;
            lblValorDescripcion.Text = articulo.Descripcion;
            lblValorPrecio.Text = "$" + articulo.Precio.ToString("C");
            lblValorMarca.Text = articulo.Marca.Descripcion;
            lblValorCategoria.Text = articulo.Categoria.Descripcion;

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            imagenes = imagenNegocio.ListarPorArticulo(articulo.Id);

            MostrarImagenActual();
        }

        private void MostrarImagenActual()
        {
            if (imagenes.Count > 0)
            {
                try
                {
                    pbImagen.Load(imagenes[indiceimagenActual].Url);

                }
                catch (Exception)
                {
                    // Manejar la excepción si la imagen no se puede cargar
                    pbImagen.Image = null;
                }
            }
            else
            {
                pbImagen.Image = null;
            }

            btnImagenAnterior.Visible =imagenes.Count > 1;
            btnImagenSiguiente.Visible = imagenes.Count > 1;



            // Cargar las imágenes del artículo
            //if (articulo.Imagenes.Count > 0)
            //{
            // Mostrar la primera imagen como ejemplo
            //    pbImagen.ImageLocation = articulo.Imagenes[0].Url; 
            //}
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            indiceimagenActual--;
            if(indiceimagenActual<0)
                indiceimagenActual = imagenes.Count - 1;

            MostrarImagenActual();
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            indiceimagenActual++;
            if(indiceimagenActual>= imagenes.Count)
                indiceimagenActual = 0;

            MostrarImagenActual();
        }
    }
}
