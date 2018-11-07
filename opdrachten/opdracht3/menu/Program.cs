using System;
using System.Collections.Generic;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 3: Menu\n\n");

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
