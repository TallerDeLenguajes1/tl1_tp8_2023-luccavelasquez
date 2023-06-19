namespace EspacioTarea
{
    public class Tarea
    {
        private int id;
        private string descripcion;
        private int duracion;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        
        public int Duracion
        {
            get => duracion;
            set => duracion = value;
        }
        
        public Tarea()
        {

        }
        public Tarea(int id, string desc, int duracion)
        {
            Id = id;
            Duracion = duracion;
            Descripcion = desc;
        }

        //esto es en caso de querer concatenar dos atributos, pero como tengo que mostrar solo uno, lo devuelvo por la
        /*public string MostrarTarea()
        {
            return "Descripcion: " + Descripcion;
        }*/

    }

}