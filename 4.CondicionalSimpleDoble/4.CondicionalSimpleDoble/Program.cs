using System;

namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura de control condicional
            //Simple 
            //1. Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web".
            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi página web");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido del sitio web");
            }

            float sueldo;
            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());
            if (sueldo > 3000) 
            {
                Console.WriteLine(nombre+" debes abonar impuestos.");
            }
        }
    }
}
