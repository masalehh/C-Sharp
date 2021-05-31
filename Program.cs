using System;

namespace freeCodeCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluranNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a Pluran Noun: ");
            pluranNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluranNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();


        }
    }
}
