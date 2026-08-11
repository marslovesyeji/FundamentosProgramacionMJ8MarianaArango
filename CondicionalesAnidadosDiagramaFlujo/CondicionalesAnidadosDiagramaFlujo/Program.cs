using System;
namespace CondicionalesAnidadosDiagramaFlujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Debe ingresar tres números diferentes");
            Console.WriteLine("Ingrese el primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2) 
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El número uno es el mayor");
                }
                else 
                {
                    Console.WriteLine("El número tres es el mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El número dos es el mayor");
                }
                else
                {
                    Console.WriteLine("El número tres es el mayor");
                }
            }
        }
    }
}
