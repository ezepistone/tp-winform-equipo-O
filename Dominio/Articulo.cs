using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dominio
{
    public class Articulo
    {   //datos minimos codigo, nombre, descrip, precio
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Marca Marca { get; set;}
        public Categoria Categoria { get; set;}
        // Lista de imagenes 
        public List<Imagen> Imagenes { get; set; }

        public Articulo()
        {
            Imagenes = new List<Imagen>();
        }
    }
}

