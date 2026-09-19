using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            lblValorCategoria.Text =  articulo.Categoria.Descripcion;

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imagenNegocio.ListarPorArticulo(articulo.Id);

            if(imagenes.Count > 0)
            {
                try
                {
                    pbImagen.Load(imagenes[0].Url);
                }
                catch (Exception)
                {
                    pbImagen.Image = null; // O asignar una imagen predeterminada si la carga falla

                }
                // Mostrar la primera imagen como ejemplo
                pbImagen.ImageLocation = imagenes[0].Url;
            }
            else
            {
                // Si no hay imágenes, puedes mostrar una imagen predeterminada o dejar el PictureBox vacío
                pbImagen.Image = null; // O asignar una imagen predeterminada
            }

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
    }
}
