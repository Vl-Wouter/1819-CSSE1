using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string text = "  Dit is een test.";
            
            for (int i = 0; i < text.Length; i++) 
            {
                Console.WriteLine(text.Substring(i, 1));
            }

            string[] woorden = text.Split();
            foreach (var woord in woorden)
            {
                Console.WriteLine(woord);
            }

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Trim(' '));

            // Collecties
            string[] menu = new string[3];
            menu[0] = "Broodje Martino";
            menu[1] = "Broodje Ham";
            menu[2] = "Broodje Kaas";

            string[] menu2 = new string[3] {"Broodje Martino", "Broodje Ham", "Broodje Kaas"};

            foreach(var broodje in menu)
            {
                Console.WriteLine(broodje);
            }

            for(int i = 0; i < menu2.Length; i++) {
                Console.WriteLine(menu2[i]);
            }

            string[,] menu3 = new string[,] { {"Broodje Martino", "4"}, {"Broodje Ham", "2"}, {"Broodje Kaas", "3"} };

            foreach (var item in menu3)
            {
                Console.Write(item);
            }
        }
    }
}
