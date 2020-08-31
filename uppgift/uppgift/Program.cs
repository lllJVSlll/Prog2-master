using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in användarman: ");

            string username = Console.ReadLine();

            Console.WriteLine("Användarman: "+ username);

            Console.WriteLine("Skriv in Ålder: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Din ålder är" + age);

            Console.WriteLine("Är du vid liv?");
                string alive = Console.ReadLine();
                var ja = true;
            var nej = false;

            Console.WriteLine("Är du vid liv?" + alive);

        }
    }
}
