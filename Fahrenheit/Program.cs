using System;
using static System.Console;

namespace Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
                double Fahren;
                WriteLine("enter Fahrenheit temperature");
                Fahren = Convert.ToDouble(ReadLine());
                WriteLine("the value of Celsius is {0}");
            ReadKey();

            
           
        }
        public double convert(double Fahrenheit)
        {
            double Celsius;
            Celsius = 5 / 9 * (Fahrenheit - 32);
            return Celsius;
        }
    }
}
