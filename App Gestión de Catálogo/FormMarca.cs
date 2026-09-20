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
    public partial class FormMarca : Form
    {
        private Marca marca = null;

        public FormMarca()
        {
            InitializeComponent();
        }
        public FormMarca(Marca seleccionada)
        {
            InitializeComponent();
            this.marca = seleccionada;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtNombre.Text;

                if (marca.Id != 0)
                {
                    negocio.Modificar(marca);
                    MessageBox.Show("Marca modificada exitosamente.");
                }
                else
                {
                    negocio.Agregar(marca);
                    MessageBox.Show("Marca agregada.");
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
