using System;

namespace person2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!");

            Console.WriteLine("Namn: ");
            var name = Console.ReadLine();

            Console.WriteLine("Välkommen till affären " + name);

            Console.WriteLine("Vi har: ");
            Console.WriteLine("Snus");
            Console.WriteLine("Nocco");
            Console.WriteLine("Choklad");
            Console.WriteLine("J-Fuel");
            Console.WriteLine("Vad vill du ha?");
            var val = Console.ReadLine();

            switch (val)
            {
                case "Snus":
                    Console.WriteLine("Du valde Snus");
                    break;

                case "Nocco":
                    Console.WriteLine("Du valde Nocco");
                    break;

                case "Choklad":
                    Console.WriteLine("Du valde Choklad");
                    break;

                case "J-Fuel":
                    Console.WriteLine("Du valde J-fuel");
                    break;



            }
            
        }
    }
}
