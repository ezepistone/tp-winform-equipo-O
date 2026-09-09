namespace App_Gestión_de_Catálogo
{
    public class Marca : EntidadBase
    {
        public Marca(int id, string nombre) : base(id, nombre) { }
        //sobrecarga de  constructor
        public Marca() { }
    }
}