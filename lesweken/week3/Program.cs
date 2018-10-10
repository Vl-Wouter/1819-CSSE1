using System;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Afdrukken van tekst in de console
            Console.WriteLine("Hello there.");

            /* Hallo
            * Dit is een comment block
            ! Thanks Better Comment
            ! Deze app doet niet veel
             */

            // Rekenmachine
            // * int c,d; kan ook als waarde later wordt toegekend
            int a = 16;
            int b = 6;

            int result1 = optellen(a, b);
            int result2 = deling(a, b);
            int result3 = verhogen(a);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

        }

        static int optellen(int a, int b) {
            return a+b;
        }

        static int verhogen(int a) {
            return a++;
        }

        static int deling(int a, int b) {
            return a/b;
        }
    }
}
