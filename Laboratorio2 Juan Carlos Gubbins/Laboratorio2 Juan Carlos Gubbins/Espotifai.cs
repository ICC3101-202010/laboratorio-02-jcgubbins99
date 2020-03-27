using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2_Juan_Carlos_Gubbins
{
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
                Console.WriteLine("No hay canciones en la lista");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
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
                    Console.WriteLine("No existe el valor que buscas entre tus canciones");
                    break;
            };

            return listafiltrada;

        }

    }
}
