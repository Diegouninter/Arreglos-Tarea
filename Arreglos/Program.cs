using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acciones acciones= new Acciones();
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        acciones.Agregar();
                        break;
                    case 2:
                        acciones.Mostrar();
                        break;
                    case 3:
                        acciones.Suma();
                        break;
                    case 4:
                        acciones.Promedio();
                        break;
                    case 5:
                        acciones.Min();
                        break;
                    case 6:
                        acciones.Max();
                        break;
                    case 7:
                        acciones.Primero();
                        break;
                    case 8:
                        acciones.Ultimo();
                        break;
                    case 9:
                        acciones.Ordenar();
                        break;
                    case 10:
                        acciones.Rev();
                        break;
                    case 11:
                        acciones.NumeroElementos();
                        break;
                    case 12:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            }

        }
        static int Menu ()
        {
            Console.WriteLine("------------");
            Console.WriteLine("1)Agregar");
            Console.WriteLine("2)Mostar");
            Console.WriteLine("3)Suma");
            Console.WriteLine("4)Promedio");
            Console.WriteLine("5)Min");
            Console.WriteLine("6)Max");
            Console.WriteLine("7)Primero");
            Console.WriteLine("8)Ultimo");
            Console.WriteLine("9)Ordenar");
            Console.WriteLine("10)Rev");
            Console.WriteLine("11)Numero de elementos");
            Console.WriteLine("12)Salir");
            Console.WriteLine("------------");
            int opc =Convert.ToInt32( Console.ReadLine());
            return opc;

        }
    }
}
