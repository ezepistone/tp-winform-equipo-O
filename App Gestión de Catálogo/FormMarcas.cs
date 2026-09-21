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
    public partial class FormMarcas : Form
    {
        private MarcaNegocio negocio = new MarcaNegocio();
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormMarca nueva = new FormMarca();
            nueva.ShowDialog();

            dataGridView1.DataSource = negocio.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Marca seleccionada = (Marca)dataGridView1.CurrentRow.DataBoundItem;

                FormMarca modificar = new FormMarca(seleccionada);
                modificar.ShowDialog();

                dataGridView1.DataSource = negocio.Listar();
            }
            else
            {
                MessageBox.Show("Seleccione una Marca de la grilla para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        Marca seleccionada = (Marca)dataGridView1.CurrentRow.DataBoundItem;
                        negocio.Eliminar(seleccionada.Id);
                        dataGridView1.DataSource = negocio.Listar();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al eliminar: " + err.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Marca para eliminar.");
            }
        }
    }
}