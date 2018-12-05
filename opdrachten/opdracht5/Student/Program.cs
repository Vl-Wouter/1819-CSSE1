using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 5 - Deel 2\n");

            Persoon p1 = new Persoon();

            Console.WriteLine(p1.GenereerWachtwoord());

            Student s1 = new Student();

            Console.WriteLine(s1.GenereerWachtwoord());
        }
    }
}
