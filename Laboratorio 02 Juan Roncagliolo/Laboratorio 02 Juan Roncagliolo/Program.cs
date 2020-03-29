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
            Espotifai lista_1 = new Espotifai();
            Clase_Cancion[] canciones = new Clase_Cancion[6];
            Clase_Cancion cancion_1 = new Clase_Cancion();
            Clase_Cancion cancion_2 = new Clase_Cancion();
            Clase_Cancion cancion_3 = new Clase_Cancion();
            Clase_Cancion cancion_4 = new Clase_Cancion();
            Clase_Cancion cancion_5 = new Clase_Cancion();
            Clase_Cancion cancion_6 = new Clase_Cancion();
            {
                cancion_1.Nombre = "Ignorantes";
                cancion_1.Artista = "Bad bunny";
                cancion_1.Album = "YHLQMDLG";
                cancion_1.Genero = "Trap";
                cancion_2.Nombre = "Relacion Rota";
                cancion_2.Artista = "Myke Towers";
                cancion_2.Album = "Easy Money Baby";
                cancion_2.Genero = "Reggaeton";
                cancion_3.Nombre = "Memoria Rota";
                cancion_3.Artista = "Arcangel";
                cancion_3.Album = "Historias de un Capricornio";
                cancion_3.Genero = "Trap";
            }
            lista_1.Agregar_Cancion(canciones, cancion_1);
            lista_1.Agregar_Cancion(canciones, cancion_2);
            lista_1.Agregar_Cancion(canciones, cancion_3);
            {
                int opcion = 0;
                int a = 0;
                while (a != 1)
                {
                    Console.WriteLine("Bienvenido:\nIngrese su nombre para continuar:");
                    string nombre = Console.ReadLine();
                    while (opcion != 3)
                    {
                        Console.WriteLine("\nBienvenido: " + nombre + "\n");
                        Console.WriteLine("-------Menu:-------\n1.Agregar Nueva Cancion:\n2.Ver Canciones:\n3.Salir:\n\nIngrese una opcion:");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                        {   Console.WriteLine("Agregar Cancion.");
                            Console.WriteLine("Ingrese el nombre de la cancion:");
                            string no = Console.ReadLine();
                            Console.WriteLine("Ingrese el artista de la cancion:");
                            string ar = Console.ReadLine();
                            Console.WriteLine("Ingrese el album de la cancion:");
                            string al = Console.ReadLine();
                            Console.WriteLine("Ingrese el genero de la cancion:");
                            string ge = Console.ReadLine();
                         
                            if (cancion_4.Nombre == null)
                            {
                                cancion_4.Nombre = no;
                                cancion_4.Artista = ar;
                                cancion_4.Album = al;
                                cancion_4.Genero = ge;
                                lista_1.Agregar_Cancion(canciones, cancion_4);
                                Console.WriteLine("\nCancion agregada con exito");
                                }
                            else if (cancion_5.Nombre == null)
                            {
                                cancion_5.Nombre = no;
                                cancion_5.Artista = ar;
                                cancion_5.Album = al;
                                cancion_5.Genero = ge;
                                lista_1.Agregar_Cancion(canciones, cancion_5);
                                Console.WriteLine("\nCancion agregada con exito");

                                }
                            else if (cancion_6.Nombre == null)
                            {
                                cancion_6.Nombre = no;
                                cancion_6.Artista = ar;
                                cancion_6.Album = al;
                                cancion_6.Genero = ge;
                                lista_1.Agregar_Cancion(canciones, cancion_6);
                                Console.WriteLine("\nCancion agregada con exito");
                                }
                            else
                            {
                                Console.WriteLine("Lo siento su plan de espotifai no permite mas canciones");
                            }
                        }
                        }
                        else if (opcion ==2)
                        {
                            Console.WriteLine("Ver Canciones");
                            lista_1.VerCanciones(canciones);
                        }
                        else if (opcion ==3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Numero invalido\nPor fvor ingrese otro numero:");
                            opcion = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    a = 1;
                }
            }


            


            



    }
            
    
    

    

    }
}
