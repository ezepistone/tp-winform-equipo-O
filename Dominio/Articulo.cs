using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestión_de_Catálogo
{
    public class Articulo
    {   //datos minimos codigo, nombre, descrip, precio
        private string codigo;
        private string nombre;
        private string descripcion;
        private double precio;

        public Articulo(string codigo, string nombre, string descripcion, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }
        //sobrecargo el constructor
        public Articulo() { }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        ///metodos
        public string mostrarDetalle()
        {
            return "Código: " + codigo + "Nombre: " + nombre + "Descripción: " + descripcion + "Precio: " + precio;
        }
    }
}

