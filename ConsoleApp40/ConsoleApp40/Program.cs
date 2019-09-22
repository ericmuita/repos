using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp40
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            bool? AreYouMajor = null;
            if (AreYouMajor == true) 
            Console.WriteLine("person is a major");
            else
                 if (!AreYouMajor.Value) 
            Console.WriteLine("person is not a major");
            else
                Console.WriteLine("person never entered a a value");




        }
    }
}
