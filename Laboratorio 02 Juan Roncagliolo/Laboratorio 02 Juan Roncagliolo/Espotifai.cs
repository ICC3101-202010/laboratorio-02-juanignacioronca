using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_Juan_Roncagliolo
{
    public class Espotifai
    {
        public Clase_Cancion[] Canciones;

        public bool Agregar_Cancion(Clase_Cancion[] Canciones, Clase_Cancion cancion)
        {
            for (int i = 0; i < Canciones.Length; i++)
            {
                if (Canciones[i] == null)
                {
                    Canciones[i] = cancion;
                    return true;
                    
                }
                else
                {
                    if (Canciones[i].Informacion() ==cancion.Informacion())
                    {
                        Console.WriteLine("ERROR!! La cancion ya estaba agregada");
                        return false;
                    }
                    else
                    {
                        continue;
                    }

                }
                
            } return true;
        }
        public void VerCanciones(Clase_Cancion[] Canciones)
        {
            //string txt="";
            for (int i = 0; i < Canciones.Length; i++)
            {
                if (Canciones[i]==null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(Canciones[i].Informacion());
                }
            }
        }

    }

}

        



