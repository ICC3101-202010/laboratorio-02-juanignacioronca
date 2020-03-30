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
        public Clase_Cancion[] ListaCancionesPorCriterio = new Clase_Cancion[6];

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
                    if (Canciones[i].Informacion() == cancion.Informacion())
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
            for (int i = 0; i < Canciones.Length; i++)
            {
                if (Canciones[i] == null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(Canciones[i].Informacion());
                }
            }
        }
        public Clase_Cancion[] CancionesPorCriterio(Clase_Cancion[] Canciones1, string criterio, string valor)
        {
            Espotifai lista_2 = new Espotifai();
            
            for (int i = 0; i <Canciones1.Length; i++)
            {
                if (Canciones1[i]!=null)
                {
                    if (criterio == "Nombre")
                    {
                        if (Canciones1[i].Nombre == valor)
                        { lista_2.Agregar_Cancion(ListaCancionesPorCriterio, Canciones1[i]); }
                        else
                        { continue; }
                    }
                    else if (criterio == "Artista")
                    {
                        if (Canciones1[i].Artista == valor)
                        { lista_2.Agregar_Cancion(ListaCancionesPorCriterio, Canciones1[i]); }
                        else
                        { continue; }
                    }
                    else if (criterio == "Album")
                    {
                        if (Canciones1[i].Album == valor)
                        { lista_2.Agregar_Cancion(ListaCancionesPorCriterio, Canciones1[i]); }
                        else
                        { continue; }
                    }
                    else if (criterio == "Genero")
                    {
                        if (Canciones1[i].Genero == valor)
                        { lista_2.Agregar_Cancion(ListaCancionesPorCriterio, Canciones1[i]); }
                        else
                        { continue; }
                    }
                    else
                    {
                        Console.WriteLine("ERROR INTENTE NUEVAMENTE");
                    }
                }
                else
                {break;}
            }
            for (int i = 0; i < ListaCancionesPorCriterio.Length; i++)
            {
                Console.WriteLine(ListaCancionesPorCriterio[i]);
            }
            return ListaCancionesPorCriterio;


        }
    }

}

        



