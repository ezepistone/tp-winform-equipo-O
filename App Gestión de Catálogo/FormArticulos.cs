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
    public partial class FormArticulos : Form
    {
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            dgv.DataSource = negocio.Listar();
            dgv.Columns["IdMarca"].Visible = false;
            dgv.Columns["IdCategoria"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ///aca va ir el evento de busqueda por texto
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear artículo");
            //FormArticulos fmr = new FormArticulos(); //falta programar el FormArticulo.cs para crear un artículo
            //fmr.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionar un artículo para modificar"); ///falta programar el FormArticulo.cs para modificar un artículo
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionar un artículo para eliminar"); ///falta programar el FormArticulo.cs para eliminar un artículo
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionar un artículo para ver el detalle");
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Articulo seleccionado = (Articulo)dgv.CurrentRow.DataBoundItem;

                FormArticulo frmArt = new FormArticulo(seleccionado);
                frmArt.ShowDialog();
            }
        }
    }
}
