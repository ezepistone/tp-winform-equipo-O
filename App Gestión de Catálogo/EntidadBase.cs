namespace App_Gestión_de_Catálogo
{
    public abstract class EntidadBase
    {
        private int id;
        private string nombre;

        public EntidadBase(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        //sobrecargo el constructor
        public EntidadBase() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre|
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}