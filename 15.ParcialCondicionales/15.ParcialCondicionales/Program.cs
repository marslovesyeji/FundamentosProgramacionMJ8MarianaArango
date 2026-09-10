using System;
namespace _15.ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un profesor necesita un programa para procesar las calificaciones de un grupo de 18 alumnos con el fin de obtener un análisis general del curso. Las notas se encuentran en un rango de 0 a 10.
            Utilizando obligatoriamente una estructura repetitiva, el programa debe realizar las siguientes operaciones:
            Lectura de datos: Solicitar por teclado la nota de cada uno de los 18 estudiantes.Cada nota ingresada debe ser procesada individualmente.
            Cálculo de Promedio: Acumular las notas para calcular al final el promedio general de todo el curso.
            Identificación de Extremos: Identificar y almacenar cuál fue la nota mayor y la nota menor de todo el conjunto ingresado.
            Conteo de Aprobados: Contar cuántos estudiantes aprobaron la asignatura(considerando que se aprueba con una nota mayor o igual a 6.0).
            Reporte de Salida: Al finalizar el ciclo, mostrar claramente en pantalla:
            El promedio general del curso.
            La nota más alta obtenida.
            La nota más baja obtenida.
            La cantidad total de estudiantes que aprobaron.*/
            float nota;
            float acum=0;
            float prom;
            float notama = 0;
            float notame = 10;
            float aprob = 0;
            for (int i = 1;i<=18;i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante (1 a 10)");
                nota = float.Parse(Console.ReadLine());
                acum = acum + nota;
                if (nota > notama)
                {
                    notama = nota;
                }
                if (nota < notame)
                {
                    notame = nota;
                }
                if (nota >= 6)
                {
                    aprob++;
                }
            }
            prom = acum / 18;
            Console.WriteLine($"El promedio general del curso es {prom}");
            Console.WriteLine($"La nota más alta del curso es {notama}");
            Console.WriteLine($"La nota más baja del curso es {notame}");
            Console.WriteLine($"{aprob} estudiantes aprobaron el curso.");
        }
    }
}
