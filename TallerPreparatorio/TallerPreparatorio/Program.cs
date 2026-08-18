using System;

namespace TallerPreparatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRIMER EJERCICIO
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
            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("El número uno es el mayor");
                        if (num2 > num3)
                        {
                            Console.WriteLine("Los números de menor a mayor son:");
                            Console.WriteLine(num3);
                            Console.WriteLine(num2);
                            Console.WriteLine(num1);
                        }
                        else
                        {
                            Console.WriteLine("Los números de menor a mayor son:");
                            Console.WriteLine(num2);
                            Console.WriteLine(num3);
                            Console.WriteLine(num1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número 3 es el mayor");
                        Console.WriteLine("Los números de menor a mayor son:");
                        Console.WriteLine(num2);
                        Console.WriteLine(num1);
                        Console.WriteLine(num3);
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("El número 2 es el mayor");
                        if (num1 > num3)
                        {
                            Console.WriteLine("Los números de menor a mayor son: ");
                            Console.WriteLine(num3);
                            Console.WriteLine(num1);
                            Console.WriteLine(num2);
                        }
                        else
                        {
                            Console.WriteLine("Los números de menor a mayor son: ");
                            Console.WriteLine(num1);
                            Console.WriteLine(num3);
                            Console.WriteLine(num2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número 3 es el mayor");
                        Console.WriteLine("Los números de menor a mayor son: ");
                        Console.WriteLine(num1);
                        Console.WriteLine(num2);
                        Console.WriteLine(num3);
                    }
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar números diferentes");
            }

        }
    }
}
