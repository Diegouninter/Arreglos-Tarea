using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Acciones
    {
        private double[] arrnombres;
       public void Agregar()
        {
            Console.WriteLine("Ingrese el numero de elementos del arreglo:");
            int n = int.Parse(Console.ReadLine());
            arrnombres = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese el elemento {i + 1}:");
                arrnombres[i] = double.Parse(Console.ReadLine());
            }
        }
        public void Mostrar()
        {
            foreach (var i in arrnombres)
            {
                Console.WriteLine($"Nombres:{i}");
            }
        }
        public double Suma()
        {
            return arrnombres.Sum();
        }
        public double Promedio()
        {
            return arrnombres.Average();
        }
        public double Min()
        {
            return arrnombres.Min();
        }
        public double Max()
        {
            return arrnombres.Max();
        }
        public double Primero()
        {
            return arrnombres.First();
        }
        public double Ultimo()
        {
            return arrnombres.Last();
        }
        public void Ordenar()
        {
            Array.Sort(arrnombres);
        }
        public void Rev()
        {
            Array.Reverse(arrnombres);
        }
        public int NumeroElementos()
        {
            return arrnombres.Length;
        }

    }
}
