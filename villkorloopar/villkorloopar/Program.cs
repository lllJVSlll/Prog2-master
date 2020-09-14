using System;
using System.ComponentModel;

namespace villkorloopar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");

            var age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Du får köpa snus!");
            }
            else
            {
                Console.WriteLine("Du får inte köpa snus än!");
            }

            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine(i);
            }
            int snus = 4;
            switch (snus)
            {
                case 1:
                    Console.WriteLine("XR");
                    break;
                case 2:
                    Console.WriteLine("Göteborg Rapé");
                    break;
                case 3:
                    Console.WriteLine("Lundgren");
                    break;
                case 4:
                    Console.WriteLine("GR ONE BLÅ :DDD");
                    break;
                case 5:
                    Console.WriteLine("Lyft eller någon annan skit");
                    break;
            }
            bool snusar = Convert.ToBoolean(Console.ReadLine());

            while (snusar)
            {

                Console.WriteLine("OM MAN HAR SNUS LEVER MAN ETT GÖTT LIV!");
            }


        }
    }
}
