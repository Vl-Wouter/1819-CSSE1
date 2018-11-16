using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vraag 1: Product is de basisklasse, MenuItem is de subklasse, aangezien deze van product overerft.

            // Aanmaken van 10 instances. Eerste 3 zijn op de verschillende manieren gedaan.
            
            Console.WriteLine("Opdracht 4");
            MenuItem item1 = new MenuItem("Broodje Hesp", "Broodje", 3.99, "Euro");
            

            MenuItem item2 = new MenuItem();
            item2.Naam = "Broodje Kaas";
            item2.Type = "Broodje";
            item2.Waarde = 2.65;
            item2.Valuta = "Euro";

            

            string[] ingredient3 = new string[]{"Spaghetti", "Bolognesesaus"};
            MenuItem item3 = new MenuItem("Spaghetti Bolognese", "Pasta", ingredient3 , 5.99, "Euro");
            

            string[] ingredient4 = new string[]{"Spaghetti", "Room", "Ei", "Spek"};
            MenuItem item4 = new MenuItem("Spaghetti Carbonara", "Pasta", ingredient4 , 7.99, "Euro");
            

            MenuItem item5 = new MenuItem("Kip zoetzuur", "Chinees" , 12.99, "Euro");
            

            string[] ingredient6 = new string[]{"Friet", "Stoofvlees"};
            MenuItem item6 = new MenuItem("Friet met stoofvlees", "Pasta", ingredient6 , 4.99, "Euro");
            

            string[] ingredient7 = new string[]{"ijs"};
            MenuItem item7 = new MenuItem("Roomijs", "Dessert", ingredient7 , 3.99, "Euro");
            

            MenuItem item8 = new MenuItem("Taart", "Dessert" , 4.99, "Euro");
            

            string[] ingredient9 = new string[]{"Varkensvlees", "Aardappel", "Groenten"};
            MenuItem item9 = new MenuItem("Varkenshaasje", "Vlees", ingredient9 , 5.99, "Euro");
            

            MenuItem item10 = new MenuItem("Frisdrank", "Drank" , 1.99, "Euro");

            // Items in een lijst zetten.
            List<MenuItem> items = new List<MenuItem>(); 
            for(int i = 0; i < 10; i++) {
                items.add(item + i);
            }

            // Overlopen van de lijst.
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }

            // Het eerste dat in me op komt voor het sorteren van een lijst is het gebruiken van de sort functie, maar aangezien dit een lijst met objecten is, zou een functie kunnen geschreven worden om de lijst te sorteren op een van de properties.
        }
    }
}
