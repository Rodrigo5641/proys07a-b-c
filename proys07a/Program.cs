using System;

namespace fp007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de candidatas: ");
            int n = int.Parse(Console.ReadLine());

            string[] nombre = new string[n];
            int[] puntos = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nombre de candidata: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Puntaje: ");
                puntos[i] = int.Parse(Console.ReadLine());
            }

            int mayor = puntos[0];
            int menor = puntos[0];
            int idxmayor = 0;

            for (int i = 1; i < n; i++)
            {
                if (puntos[i] > mayor)
                {
                    mayor = puntos[i];
                    idxmayor = i;
                }
                if (puntos[i] < menor)
                {
                    menor = puntos[i];
                }
            }

            Console.WriteLine("La cantidad de candidatas es: " + puntos.Length);
            Console.WriteLine($"El mayor puntaje ingresado es de {nombre[idxmayor]} con: {puntos[idxmayor]}");
            Console.WriteLine("La menor puntuación es: " + menor);
            Console.ReadKey();
        }
    }
}