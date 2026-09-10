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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos frm = new FormArticulos(); 
            frm.ShowDialog();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas frm = new FormMarcas();
            frm.ShowDialog();

        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias frm = new FormCategorias();
            frm.ShowDialog();
        }
    }
}
