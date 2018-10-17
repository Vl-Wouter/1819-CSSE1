using System;

namespace Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 0; i < 11; i++) {
            //     for(int j = 0; j < 11; j++) {
            //         Console.WriteLine( i + " * " + j + " = " + table(i, j));
            //     }
            //     Console.WriteLine(" ");
            // }

            int getal = 3;
            do {
                Console.WriteLine(getal);
                getal++;
            } while(getal < 12);
        }

        static int table(int table, int num) {
            return table * num;
        }
    }
}
