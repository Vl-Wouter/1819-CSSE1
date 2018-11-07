using System;
using System.Collections.Generic;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 3: Menu");
            // // De makkelijke oplossing.
            // Program program = new Program();
            // // string[,] menuItems = new[,] {{"Plat water", "1"}, {"Cola 25cl","1.50"}, {"Cola 33cl","2"},  {"Witte wijn","3"}, {"Pils","2"}, {"Toast","5"}, {"Kaasplank","4"}};

            // string[] items = new[] {"Plat Water", "Cola 25cl", "Cola 33cl", "Witte wijn", "Pils", "Toast", "Kaasplank"};
            // double[] prijzen = new[] {1.00, 1.50, 2.00, 3.00, 2.00, 5.00, 4.00};
            // int length = items.GetLength(0);

            // program.ReadArray(length, items, prijzen);

            // // Sorteren op naam.

            // Array.Sort(items, prijzen);
            // Console.WriteLine("\nGesorteerd op naam:");
            // program.ReadArray(length, items, prijzen);

            // // Sorteren op prijs.

            // Array.Sort(prijzen, items);
            // Console.WriteLine("\nGesorteerd op prijs:");
            // program.ReadArray(length, items, prijzen);

            Dictionary<string, double> menu = new Dictionary<string, double>();

            // Add items.
            menu.Add("Plat water", 1.00);
            menu.Add("Cola 25cl", 1.50);
            menu.Add("Cola 33cl", 2.00);
            menu.Add("Witte wijn", 3.00);
            menu.Add("Pils", 2.00);
            menu.Add("Toast", 5.00);
            menu.Add("Kaasplank", 4.00);

            // Read out.

            foreach(var item in menu) {
                Console.WriteLine(item.Key + " - " + item.Value + "EUR");
            }

            // Sorted by name.

            List<string> itemList = new List<string>();
            foreach(var key in menu) {
                itemList.Add(key.Key);
            }
            
            itemList.Sort();

            Console.WriteLine("\nGesorteerd op naam:");
            foreach(var item in itemList) {
                Console.WriteLine(item + " - " + menu[item] + "EUR");
            }

            // Find a certain item.
            Console.WriteLine("\nGeef een naam van een item op:");
            string value = Console.ReadLine();
            try
            {
                Console.WriteLine(value + " kost " + menu[value] + "EUR.");
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("Dit item staat niet op dit menu.");
            }

        }

        void ReadArray(int length, string[] array1, double[] array2) {
            for(int i = 0; i < length; i++) {
                Console.WriteLine(array1[i] + " - " + array2[i] + "EUR");
            }
        }
    }
}
