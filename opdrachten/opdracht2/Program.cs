using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tafel
            Console.WriteLine("Geef een getal in:");
            int tafel = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 10; i++) {
                Console.WriteLine(i + " * " + tafel + " = " + (i*tafel));
            }
            
            // Factulteit
            Console.WriteLine("Geef een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());
            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine(fac);
            
            
            // Fibonacci
            Console.WriteLine("Geef een eindgetal in:");
            int eindfib = Convert.ToInt32(Console.ReadLine());
            int g0 = 0;
            int g1 = 1;
            int next = 0;

            for(int i = 0; i < eindfib; i++) {
                if(i == 0) {
                    next = 0;
                } else if(i == 1) {
                    next = 1;
                } else {
                    next = g0 + g1;
                    g0 = g1;
                    g1 = next;
                }
                Console.WriteLine(next);
            }
        }
    }
}
