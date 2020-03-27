using System;
using System.Collections.Generic;
using System.Text;

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
            string informacion = ("Genero: " + Genero + "\n" + "Artista: " + Artista + "\n" + "Album: " + Album + "\n" + "Nombre canción: " + Nombre);
            return informacion;
        }
    }

}
