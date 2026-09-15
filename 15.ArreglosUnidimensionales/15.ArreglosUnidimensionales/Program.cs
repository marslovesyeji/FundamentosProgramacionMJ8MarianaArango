using System;

namespace _15.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] num = new int[5];
            num[0] = 15;
            num[1] = 56;
            num[2] = 20;
            num[3] = 47;
            num[4] = 27;
            Console.WriteLine($"El dato almacenado en la posición cuatro con índice 3 es: {num[3]}");

            float[] not = new float[3];
            not[0] = 3.6f;
            not[1] = 4.3f;
            not[2] = 5.0f;

            //Otras formas de inicializar o declarar
            char[] simb = new char[] { '?', '(', '5', 'f' } ;
            bool[] valoresverdad = { true, false, true, true, false };

            string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingrese el nomnbre para la P{i + 1}:I{i}");
                nombres[i] = Console.ReadLine();
            }*/

            int[] enteros = new int[100];
            for(int i = 0; i<100; i++)
            {
                enteros[i] = 10;
                Console.WriteLine($"El dato almacenado en la posición {i + 1} con índice {i} es: {enteros[i]}");
            }
        }
    }
}
