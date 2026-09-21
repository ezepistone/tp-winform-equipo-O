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
    public partial class FormCategorias : Form
    {
        private CategoriaNegocio negocio = new CategoriaNegocio();
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.Listar();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FormCategoria nueva = new FormCategoria();
            nueva.ShowDialog();

            dataGridView1.DataSource = negocio.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Categoria seleccionada = (Categoria)dataGridView1.CurrentRow.DataBoundItem;

                FormCategoria modificar = new FormCategoria(seleccionada);
                modificar.ShowDialog();

                dataGridView1.DataSource = negocio.Listar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoría de la grilla para modificar.");
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
                        Categoria seleccionada = (Categoria)dataGridView1.CurrentRow.DataBoundItem;
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
                MessageBox.Show("Seleccione una Categoria para eliminar.");
            }
        }

        
    }
}