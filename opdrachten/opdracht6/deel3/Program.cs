using System;

namespace deel3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 6 - Deel 3 \nFactory: \n");
            VormFactory potlood = new ConcreteVormFactory();

            IVorm cirkel = potlood.GetVorm("Cirkel");
            cirkel.Teken();

            IVorm rechthoek = potlood.GetVorm("Rechthoek");
            rechthoek.Teken();

            IVorm parallellogram = potlood.GetVorm("Parallellogram");
            parallellogram.Teken();

            Console.WriteLine("\n(Bob the) Builder: \n");

            // Ik begrijp de Builder niet zo goed, daarom implementatie voorlopig niet gedaan.
        }
    }
}
