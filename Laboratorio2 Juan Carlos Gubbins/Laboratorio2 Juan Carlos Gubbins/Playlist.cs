using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2_Juan_Carlos_Gubbins
{
    class Playlist
    {
        public string NombrePlaylist;
        public List<Cancion> listplay = new List<Cancion>();



        public Playlist(string _nombrepl, List<Cancion> listacancion)
        {
            
            this.NombrePlaylist = _nombrepl;
            this.listplay = listacancion;

        }

        public string informationPLN()
        {
            string informacion1pl = ("Nombre Playlist:" + NombrePlaylist);
            return informacion1pl;
        }

        public string informationPLL()
        {
            string stringaux1 = " ";
            if (listplay.Count == 0)
            {
                return "No hay canciones en la playlist";

            }

            else
            {
                for (int i = 0; i < listplay.Count; i++)
                {
                    stringaux1 += "Cancion" + " " + (i + 1) + "\n";
                    stringaux1 += "============ \n";
                    stringaux1 += listplay[i].information() + "\n";

                    stringaux1 += " ";


                }
                return stringaux1;









                
            }

        }
    }
}

