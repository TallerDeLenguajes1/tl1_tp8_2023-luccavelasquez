
using EspacioTarea;
internal class Program
{
    const int cantTareas = 3;
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string[] descripciones = {"Jugar","Correr","Dormir"};
        int[] duraciones = new int[3]; //declaramos y creamos el obj array que tiene espacio para 3 valores
        duraciones[0] = 5;
        duraciones[1] = 10;
        duraciones[2] = 20;

        var pendientes = new List<Tarea>();
        var realizadas = new List<Tarea>();
 
        for (int i = 0; i < cantTareas; i++)
        {
            var TareaX = new Tarea (i+1,descripciones[i],duraciones[i]);
            pendientes.Add(TareaX);
            //Console.WriteLine(TareaX.Descripcion);
        }
        //muestro tareas
        for (int i = 0; i < cantTareas; i++)
        {
            Console.WriteLine(i+ "-Descripcion: " + pendientes[i].Descripcion + " Duracion: "+pendientes[i].Duracion);
           
        }


        //cambiando tarea a realizada

        string idIngresado = ""; //hacer con el tryparse practica parcial?
        int idIngresadoInt = 0;

        Console.WriteLine("Ingrese el numero de la tarea que decea mover a tareas realizadas: ");
        idIngresado = Console.ReadLine(); 
        int.TryParse(idIngresado, out idIngresadoInt);
        Tarea TareaAux = pendientes[idIngresadoInt];
        realizadas.Add(TareaAux);
        pendientes.RemoveAt(idIngresadoInt);
        


        //para mostrar ocurre el problema de que cada lista tiene distinto tamaño y salta error
        /*for (int i = 0; i < cantTareas; i++)
        {
            Console.WriteLine(i+ "-Descripcion: " + pendientes[i].Descripcion);   
        }*/

        //agregar la sumatoria de horas

        


    }
}