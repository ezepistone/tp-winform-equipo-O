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
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                dgv.DataSource = negocio.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             { FormArticulo frm = new FormArticulo(); frm.ShowDialog(); } 

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgv.CurrentRow.DataBoundItem;
                FormArticulo frm = new FormArticulo(seleccionado);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccione un artículo para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar el artículo?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgv.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);
                    dgv.DataSource = negocio.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgv.CurrentRow.DataBoundItem;
                FormDetalleArticulo frm = new FormDetalleArticulo (seleccionado);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccione un artículo para ver el detalle");
            }
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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgv.DataSource = negocio.Listar();
        }
    }
}
