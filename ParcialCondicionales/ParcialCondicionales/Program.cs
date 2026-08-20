using System;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string signo;
            string mes;
            Console.WriteLine("Por favor ingresar los datos con mayúscula inicial y teniendo en cuenta las tildes (Géminis, Cáncer y Escorpión)");
            Console.WriteLine("Ingrese su mes de nacimiento");
            mes = Console.ReadLine();
            Console.WriteLine("Ingrese su signo zodiacal");
            signo = Console.ReadLine();
            switch (mes)
            {
                case "Enero":
                    if (signo == "Tauro" || signo == "Virgo" || signo == "Capricornio")
                    {
                        Console.WriteLine("Su elemento es tierra");
                    }
                    else if (signo == "Géminis" || signo == "Libra" || signo == "Acuario")
                    {
                        Console.WriteLine("Su elemento es aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Febrero":
                    if (signo == "Cáncer" || signo == "Escorpión" || signo == "Piscis")
                    {
                        Console.WriteLine("Su elemento es agua");
                    }
                    else if (signo == "Géminis" || signo == "Libra" || signo == "Acuario")
                    {
                        Console.WriteLine("Su elemento es aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Marzo":
                    if (signo == "Cáncer" || signo == "Escorpión" || signo == "Piscis")
                    {
                        Console.WriteLine("Su elemento es agua");
                    }
                    else if (signo == "Aries" || signo == "Leo" || signo == "Sagitario")
                    {
                        Console.WriteLine("Su elemento es fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Abril":
                    if (signo == "Tauro" || signo == "Virgo" || signo == "Capricornio")
                    {
                        Console.WriteLine("Su elemento es tierra");
                    }
                    else if (signo == "Aries" || signo == "Leo" || signo == "Sagitario")
                    {
                        Console.WriteLine("Su elemento es fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Mayo":
                    if (signo == "Tauro" || signo == "Virgo" || signo == "Capricornio")
                    {
                        Console.WriteLine("Su elemento es tierra");
                    }
                    else if (signo == "Géminis" || signo == "Libra" || signo == "Acuario")
                    {
                        Console.WriteLine("Su elemento es aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Junio":
                    if (signo == "Cáncer" || signo == "Escorpión" || signo == "Piscis")
                    {
                        Console.WriteLine("Su elemento es agua");
                    }
                    else if (signo == "Géminis" || signo == "Libra" || signo == "Acuario")
                    {
                        Console.WriteLine("Su elemento es aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Julio":
                    if (signo == "Cáncer" || signo == "Escorpión" || signo == "Piscis")
                    {
                        Console.WriteLine("Su elemento es agua");
                    }
                    else if (signo == "Aries" || signo == "Leo" || signo == "Sagitario")
                    {
                        Console.WriteLine("Su elemento es fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Agosto":
                    if (signo == "Tauro" || signo == "Virgo" || signo == "Capricornio")
                    {
                        Console.WriteLine("Su elemento es tierra");
                    }
                    else if (signo == "Aries" || signo == "Leo" || signo == "Sagitario")
                    {
                        Console.WriteLine("Su elemento es fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Septiembre":
                    if (signo == "Tauro" || signo == "Virgo" || signo == "Capricornio")
                    {
                        Console.WriteLine("Su elemento es tierra");
                    }
                    else if (signo == "Géminis" || signo == "Libra" || signo == "Acuario")
                    {
                        Console.WriteLine("Su elemento es aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Octubre":
                    if (signo == "Cáncer" || signo == "Escorpión" || signo == "Piscis")
                    {
                        Console.WriteLine("Su elemento es agua");
                    }
                    else if (signo == "Géminis" || signo == "Libra" || signo == "Acuario")
                    {
                        Console.WriteLine("Su elemento es aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Noviembre":
                    if (signo == "Cáncer" || signo == "Escorpión" || signo == "Piscis")
                    {
                        Console.WriteLine("Su elemento es agua");
                    }
                    else if (signo == "Aries" || signo == "Leo" || signo == "Sagitario")
                    {
                        Console.WriteLine("Su elemento es fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Diciembre":
                    if (signo == "Tauro" || signo == "Virgo" || signo == "Capricornio")
                    {
                        Console.WriteLine("Su elemento es tierra");
                    }
                    else if (signo == "Aries" || signo == "Leo" || signo == "Sagitario")
                    {
                        Console.WriteLine("Su elemento es fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
            }
        }
    }
}
