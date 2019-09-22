using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace StringsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Capital("oliver");
            Uppet();
            string text = " @ $ %  oliver kipkemei ";
            char[] separators = { ' ', '@', '$', '%' };
            string reduced = text.Trim(separators);
            Console.WriteLine(reduced);
            Console.ReadKey();
        }
        public static string Capital(string str)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 0;i<str.Length;i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch)) 
                {
                    result.Append(ch);
                    Console.WriteLine(result);
                }
            }
           // Console.WriteLine(result);
           Console.WriteLine(result.ToString());
            return result.ToString();
        }
        public static void Uppet()
        {
             string  text = "Violin virtuoso";
            for(int i = 0;i<text.Length;i++)
            {
                string result = text.ToUpper();
               Console.WriteLine(result);
                break;
            }
          
        }
    }
}
