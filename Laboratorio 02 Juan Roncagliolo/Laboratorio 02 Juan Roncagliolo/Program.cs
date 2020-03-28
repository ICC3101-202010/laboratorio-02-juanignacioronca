using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_Juan_Roncagliolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase_Cancion cancion1 = new Clase_Cancion();
            cancion1.Nombre = "Ignorantes";
            cancion1.Artista = "Bad Bunny";
            cancion1.Album = "YHLQMDLG";
            cancion1.Genero = "Trap";

            Console.WriteLine(cancion1.Informacion());
            Console.ReadKey();
        }
    }
}
