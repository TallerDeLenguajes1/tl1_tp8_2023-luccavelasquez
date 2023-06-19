
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
        for (int i = 0; i < cantTareas; i++) //se puede hacer con un foreach
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
        
        //muestra las tareas que quedaron en pendientes
        /*foreach (var tarea in pendientes)
        {
            int j = 0;
            Console.WriteLine(j + "-Descripcion: " + tarea.Descripcion);
            j++;            

        }*/

        //3
        /*
        string descrip = "";
        
        Console.WriteLine("Ingrese la descripcion de tarea que decea buscar: ");
        descrip = Console.ReadLine();

        // // pendientes.Find(tarea3 => tarea3.Id ==3) devuelve tarea 3 (buscar, clae!)
        //que pasa si no me encuentra la tarea? No enteiendo bien la funcion
        Tarea tareaBuscada = pendientes.Find(tareaBuscada => tareaBuscada.Descripcion == descrip);
        */


        //4 agregar la sumatoria de horas

        int sumario = 30; //preguntar si tiene que ser la sumatoria de las tareas realizaas o de las pendientes?
        string directorio = @"C:\repositorioTp8\tl1_tp8_2023-luccavelasquez";
        string NuevoArchivo = directorio + @"\Horas_trabajadas.txt";

        if (!File.Exists(NuevoArchivo)) //se pregunta si el archivo existe o no, en caso de no existir lo crea
        {
            File.Create(NuevoArchivo); //crea el archivo en la ruta

        } //preguntar si hay q utilizar los using para usar las librerias

        var archivo = new StreamWriter("Horas_trabajadas.txt");//preg porque no hace falta poner toda la dire
        archivo.WriteLine(sumario);
        archivo.Close();


    }
}