using System;
using static System.Console;

namespace EXPENDITURE_APPLICATION
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings=20000;
            while(savings>=5000)
            {
                WriteLine("proceed");
                WriteLine("Enter your expenses");
                ReadLine();
                ReadKey();
            }
        }

    }
}
