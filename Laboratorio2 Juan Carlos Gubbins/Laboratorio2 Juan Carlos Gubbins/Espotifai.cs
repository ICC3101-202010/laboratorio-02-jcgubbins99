using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2_Juan_Carlos_Gubbins
{
    class Espotifai
    {

        public List<Cancion> listacanciones;
        public List<Cancion> listafiltrada;
        public List<Playlist> listplay2;

        public Espotifai()
        {
            listacanciones = new List<Cancion>();
            listplay2 = new List<Playlist>();
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
                Console.WriteLine("No hay canciones agregadas aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Canción" + " " + (i + 1));
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
                    Console.WriteLine("No existen canciones que cumplan con el criterio y valor seleccionado");
                    break;
            };

            return listafiltrada;

        }
        public bool GenerarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            List<Cancion> listplay = CancionesPorCriterio(criterio, valorCriterio);
            if (listplay.Count == 0)
            {
                Console.WriteLine("Por ende, no ha sido posible  crear la playlist");
                return false;
            }
                
            for (int i = 0; i < listplay2.Count; i++)
            {
                if (listplay2[i].NombrePlaylist == nombrePlaylist)
                {
                    Console.WriteLine("La playlist ya existe");
                    return false;
                }
            }
            Playlist listplay3 = new Playlist(nombrePlaylist, listplay);
            listplay2.Add(listplay3);
            Console.WriteLine("Playlist exitosamente agregada");
            return true;

        }
        public string VerMisPlaylists()
        {
            string stringaux2 = " ";
            if (listplay2.Count == 0)
            {
                return ("No hay playlists en la lista");
            }

            else
            {
                for (int i = 0; i < listplay2.Count; i++)
                {
                    stringaux2 += "Playlist" + " " + (i + 1)+"\n";
                    stringaux2 += "============ \n";
                    stringaux2 += listplay2[i].informationPLN() + "\n";
                    stringaux2 += "============ \n";
                    stringaux2 += listplay2[i].informationPLL() + "\n";
                    

                }
                return stringaux2;


            }
        }







    }
}

            
  
