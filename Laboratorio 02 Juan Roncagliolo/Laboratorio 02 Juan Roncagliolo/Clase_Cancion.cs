using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_Juan_Roncagliolo
{
    public class Clase_Cancion 
    {

        public string Nombre;
        public string Artista;
        public string Album;
        public string Genero;

        public string Informacion()
        {
            string N = Nombre;
            string Al = Album;
            string Ar = Artista;
            string G = Genero;
            string info = "Nombre: "+N + ", Artista: " + Ar + ", Album: " + Al +", Genero: " + G+"\n";
            return info;
        }
    }
}
