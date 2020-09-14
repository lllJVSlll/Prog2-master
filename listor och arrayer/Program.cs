using System;

namespace listor_och_arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameinput = new string[5];


            Console.WriteLine("Skriv in 5 namn: ");

            for (int i = 0; i < nameinput.Length; i++)
            {
                nameinput[i] = Console.ReadLine();
            }
            Array.Reverse(nameinput);
                
            Console.WriteLine("Dina namn är ");

            for (int i = 0; i < nameinput.Length; i++)
            {
                Console.WriteLine(nameinput[i]);
                
            }
            
        }
    }
}
