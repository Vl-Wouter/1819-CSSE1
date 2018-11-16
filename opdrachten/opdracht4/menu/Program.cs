using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 4");
            MenuItem item1 = new MenuItem("Broodje Hesp", "Broodje", 3.99, "Euro");
            Console.WriteLine(item1.ToString());

            string[] ingredient2 = new string[]{"Brood", "Kaas"};
            MenuItem item2 = new MenuItem("Broodje Kaas", "Broodje", ingredient2, 2.80, "Euro");
        }
    }
}
