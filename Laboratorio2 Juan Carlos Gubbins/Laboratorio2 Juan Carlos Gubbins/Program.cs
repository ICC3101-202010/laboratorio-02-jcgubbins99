using System;
using System.Collections.Generic;
//Alumno: Juan Carlos Gubbins
namespace Laboratorio2_Juan_Carlos_Gubbins
{

    class Program
    {
        static void Main()
        {
            Espotifai esp = new Espotifai();
            

            Console.WriteLine("Bienvenido ¿Que deseas hacer? ");
            Console.WriteLine("1.-Ver todas las canciones de la lista");
            Console.WriteLine("2.-Agregar una canción");
            Console.WriteLine("3.-Ver canciones por criterio");
            Console.WriteLine("4.-Salir del programa");

            string accion = null;
            while (accion != "4")
            {

                accion = Console.ReadLine();
                switch (accion)
                {
                    case "1":
                        Console.WriteLine("=====================");
                        Console.WriteLine("Canciones de la lista:");
                        Console.WriteLine("=====================");
                        esp.VerCanciones(esp.listacanciones);
                        break;
                    case "2":
                        Console.WriteLine("=====================");
                        Console.WriteLine("Agregar cancion:");
                        Console.WriteLine("=====================");
                     

                        string nombre="";
                        string genero="";
                        string album="";
                        string artista = "";
                        
                        Console.WriteLine("Ingrese el nombre de la canción:");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el género de la canción:");
                        genero = Console.ReadLine();

                        Console.WriteLine("Ingrese el album de la canción:");
                        album = Console.ReadLine();

                        Console.WriteLine("Ingrese el artista de la canción:");
                        artista = Console.ReadLine();

                        Cancion c1 = new Cancion(genero,artista,album,nombre);

                        esp.AgregarCancion(c1);
                        

                        break;
                    case "3":
                        string criterio = "";
                        string valor = "";
                        Console.WriteLine("==================");
                        Console.WriteLine("Elija un criterio");
                        criterio = Console.ReadLine();
                        Console.WriteLine("Elija un valor de ese criterio");
                        valor = Console.ReadLine();
                        Console.WriteLine("===============================================================================");
                        Console.WriteLine("Estas canciones comparten el mismo valor:"+" " + valor +" "+ "en el criterio:"+" " + criterio);
                        Console.WriteLine("===============================================================================");
                        esp.CancionesPorCriterio(criterio, valor);
                        esp.VerCanciones(esp.CancionesPorCriterio(criterio, valor));
                        Console.WriteLine("========================================");
                        break;
                    case "4":
                        Console.WriteLine("=====================");
                        Console.WriteLine("Has salido del programa");
                        Console.WriteLine("=====================");
                        
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción válida");
                        break;


                }

            }





           
            
           
            

        }
     }



    
}
