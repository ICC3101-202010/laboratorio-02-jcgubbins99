using System;
using System.Collections.Generic;
//Alumno: Juan Carlos Gubbins
namespace Laboratorio2_Juan_Carlos_Gubbins
{

    class Cancion
    {
        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;
        public Cancion(string _genero, string _artista, string _album, string _nombre)
        {
            this.Genero = _genero;
            this.Artista = _artista;
            this.Album = _album;
            this.Nombre = _nombre;
        }
        public string information()
        {
            string informacion = ("Genero: " + Genero +"\n"+ "Artista: " + Artista +"\n"+ "Album: " + Album +"\n"+ "Nombre canción: " + Nombre);
            return informacion;
        }
    }









    class Espotifai
    {

        public List<Cancion> listacanciones;
        public List<Cancion> listafiltrada;

        public Espotifai()
        {
            listacanciones = new List<Cancion>();
            
        }
        public bool AgregarCancion(Cancion _cancion)
        {

            for (int i = 0; i < listacanciones.Count; i++)
            {

                Cancion ci = listacanciones[i];

                if ((ci.Genero == _cancion.Genero) && (ci.Artista == _cancion.Artista) && (ci.Album == _cancion.Album) && (ci.Nombre == _cancion.Nombre))
                {
                    Console.WriteLine("Cancion ya estaba antes agregada");
                    return false;
                }

            }

            listacanciones.Add(_cancion);
            Console.WriteLine("Canción agregada");
            Console.WriteLine("================");
            return true;
        }
        public void VerCanciones(List<Cancion> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay canciones en la lista"); }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("Canción" +" "+ (i+1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].information());
                    Console.WriteLine(" ");
                    
                }
            }

            

        }

        public List<Cancion> CancionesPorCriterio(string _criterio, string _valor)
        {
             listafiltrada = new List<Cancion>();

            switch (_criterio)
            {
                case "Genero":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Genero == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "genero":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Genero == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Artista":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Artista == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "artista":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Artista == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Album":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Album == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "album":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Album == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Nombre":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Nombre == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "nombre":
                    foreach (Cancion _filtro in listacanciones)
                    {
                        if (_filtro.Nombre == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("No existe el valor que buscas entre tus canciones");
                    break;
            };

            return listafiltrada;

        }








    class Playlist
        {
            string NombrePlaylist;

        }

















    }
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
