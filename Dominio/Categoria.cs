namespace App_Gestión_de_Catálogo
{
    public class Categoria : EntidadBase
    {
        public Categoria(int id, string nombre) : base(id, nombre) { }
        //sobrecargo el constructor
        public Categoria() { }
    }
}