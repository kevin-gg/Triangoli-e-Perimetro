using System;

namespace Funzioni
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Funzioni.InserisciLato();
            double b = Funzioni.InserisciLato();
            double c = Funzioni.InserisciLato();
            Funzioni.Triangolo(a, b, c);
            Funzioni.Perimetro(a, b, c);
        }
    }
}
