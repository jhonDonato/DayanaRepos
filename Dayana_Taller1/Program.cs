using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayana_Taller1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Total de alumnos?: ");
            int cantidad = int.Parse(Console.ReadLine());
            int contarMenores12 = 0;
            double notaMayor = 0;
            double notaMenor = 20;
            for (int i = 1; i <= cantidad; i++) 
            {
                Console.Write("Ingresa la nota del alumno " + i + ": ");
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 && nota > 20)
                {
                    Console.WriteLine("Nota no válida, debe ser entre 0 y 20.");
                }
                if (nota < 12)
                {
                    contarMenores12++;
                }
                if (nota > notaMayor)
                {
                    notaMayor = nota;
                }
                if (nota < notaMenor)
                {
                    notaMenor = nota;
                }

            }
            for (int O = 1; O <= cantidad; O++)
            {
                Console.Write("Ingresa la nota del alumno " + O + ": ");
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 && nota > 20)
                {
                    Console.WriteLine("Nota no válida, debe ser entre 0 y 20.");
                }
                if (nota < 12)
                {
                    contarMenores12++;
                }
                if (nota > notaMayor)
                {
                    notaMayor = nota;
                }
                if (nota < notaMenor)
                {
                    notaMenor = nota;
                }

            }
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Alumnos con nota menor a 12: " + contarMenores12);
            Console.WriteLine("Mayor nota: " + notaMayor);
            Console.WriteLine("Menor nota: " + notaMenor);
            Console.WriteLine("TERMINAMOS CON EL TALLER ");

            Console.ReadKey();
        }
    }


}
        

