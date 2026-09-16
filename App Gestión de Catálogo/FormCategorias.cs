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
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.SetearConsulta("SELECT * FROM CATEGORIAS");
            ad.ejecutarLectura();

            string resultado = "";
            while (ad.Lector.Read())
            {
                resultado = resultado + ad.Lector["Descripcion"].ToString() + "\n";
            }

            ad.cerrarConexion();

            MessageBox.Show(resultado);
        }
    }
}
