using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = 0;
            if (i!=null)
            {
                Console.WriteLine("i is not null");
            }
            else
            {
                Console.WriteLine("i is null");
            }
            Console.ReadKey();
        }
    }
}
