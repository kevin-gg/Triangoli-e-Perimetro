using System;

namespace Funzioni
{
    public class Funzioni
    {
        public static double InserisciLato()
        {
            Console.WriteLine("Inserisci il lato");
            double n = Convert.ToDouble(Console.ReadLine());
            return n;
        }
        public static void Triangolo(double n1, double n2, double n3)
        {

            if (n1 == n2 && n1 == n3)
            {
                Console.WriteLine("Il triangolo è Equilatero");
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                Console.WriteLine("Il triangolo è Isoscele");
            }
            else
            {
                Console.WriteLine("Il triangolo è Scaleno");
            }


        }
        public static void Perimetro(double n1, double n2, double n3)
        {


             Console.WriteLine($"Perimetro = {n1 + n2 + n3}");
           








        }
    }
}


