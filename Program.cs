using System;

namespace Proyecto_Arbol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Selecciona una opción");
                Console.WriteLine();
                Console.WriteLine("1.- Listas");
                Console.WriteLine("2.- Pilas");
                Console.WriteLine("3.- Colas");
                Console.WriteLine("4.- Árbol");
                Console.WriteLine("5.- Salir");
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Proyecto_Arbol.LISTA.Menu_Lista.Listas(new string[0]);
                        break;



                    case 2:
                        Console.Clear();
                        Proyecto_Arbol.PILAS.Menu_Pila.Pilas(new string[0]);
                        break;



                    case 3:
                        Console.Clear();
                        Proyecto_Arbol.COLAS.Menu_Cola.Colas(new string[0]);
                        break;



                    case 4:
                        Console.Clear();
                        Proyecto_Arbol.ARBOL.Menu_Arbol.Arboles(new string[0]);
                        break;



                    case 5:
                        Console.WriteLine();
                        break;



                    default:
                        Console.WriteLine("Selecciones otra opción");
                        break;
                }

            }
        }
    }
}