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
        }
    }
}
