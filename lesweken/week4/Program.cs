using System;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekenen...");
            // int a1 = 100;
            // int a2 = 7;
            // int a3 = 3;
            // int a = ((a1 + a2) * a3);

            // int b1 = 5;
            // int b2 = 406;
            // int b3 = 7367;
            // int b4 = 69;
            // int b = (b1 * ((b2 + b3) / b4));

            // int c1 = 73;
            // int c2 = 41;
            // int c3 = 39;
            // int c = ((c1 * c2) - c3);

            // int d1 = 7;
            // int d2 = 8;
            // int d3 = 19;
            // int d = ((d1 * d2) - d3);

            // int result = (a + b + c + d)
            int result = sum(sum(multiply(sum(100, 7), 3), multiply(5, division(sum(406, 7367), 69))), sum(subtract(multiply(73, 41), 39), subtract(multiply(7, 8), 19)));

            Console.WriteLine("Het resultaat is: " + result);

        }

        static int sum(int a, int b) {
            return a + b;
        }

        static int multiply(int a, int b) {
            return a * b;
        }

        static int subtract(int a, int b) {
            return a - b;
        }

        static int division(int a, int b) {
            return a / b;
        }
    }
}
