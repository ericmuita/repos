using System;
using static System.Console;

namespace addition_method
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int summationresult;
            Summation(2,23,out summationresult);
            WriteLine(summationresult);*/
            /*int a;
           bool B= int.TryParse(ReadLine(), out a);
            WriteLine(B);*/

            //string a, b;
            //if(a.Equals(b,StringComparison.))
           
            string a= "hello";
            string b= "HELLO";
            WriteLine("enter word");
            /* string  =ReadLine();
             WriteLine("enter word");
             string c = ReadLine();

             if (a.Equals(b, StringComparison.OrdinalIgnoreCase))
             {
                 WriteLine("correct");

             }
             else
             {
                 WriteLine("not correct");
             }*/
             if(a=="hello"&& b=="Hello")
            {
                WriteLine("True");
            }
             else
            {
                WriteLine("false");
            }

            ReadKey();
           

            
            
        }
        public static void Summation(int a,int b,out int summationresult)
        {
            summationresult = a + b;
            
        }
    }
}
