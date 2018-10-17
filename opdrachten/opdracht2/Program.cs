using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factulteit
            int getal = 10;
            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine(fac);
            // Fibonacci
        }
    }
}
