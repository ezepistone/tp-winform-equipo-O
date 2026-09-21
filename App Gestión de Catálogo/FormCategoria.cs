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
    public partial class FormCategoria : Form
    {
        private Categoria categoria = null;
        public FormCategoria()
        {
            InitializeComponent();
        }

        public FormCategoria(Categoria seleccionada)
        {
            InitializeComponent();
            this.categoria = seleccionada;
            txtNombre.Text = categoria.Descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                    categoria = new Categoria();

                categoria.Descripcion = txtNombre.Text;

                if (categoria.Id != 0)
                {
                    negocio.Modificar(categoria);
                    MessageBox.Show("Categoria modificada correctamente.");
                }
                else
                {
                    negocio.Agregar(categoria);
                    MessageBox.Show("Categoria agregada.");
                }

                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
