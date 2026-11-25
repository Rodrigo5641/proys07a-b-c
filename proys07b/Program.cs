using System;

namespace fp007
{
    internal class proys07b
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());
            int[] lista = new int[n];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                lista[i] = int.Parse(Console.ReadLine());
            }

            int mayor = lista[0];
            int menor = lista[0];

            for (int i = 1; i < lista.Length; i++)
            {
                if (lista[i] > mayor) mayor = lista[i];
                if (lista[i] < menor) menor = lista[i];
            }

            Console.WriteLine("CANTIDAD DE NÚMEROS INGRESADOS ES: " + n);
            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
            Console.ReadKey();
        }
    }
}