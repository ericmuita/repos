using System;

namespace tuples1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = cats().Value.cat1 + cats().Value.cat2 + cats().Value.cat3;
            var b = labs().Value.lab1 + labs().Value.lab2 + labs().Value.lab3;
            var c = mainexam().Value.exam1 + mainexam().Value.exam2 + mainexam().Value.exam3 + mainexam().Value.exam4 +
                    mainexam().Value.exam5 + mainexam().Value.exam6;
            if (a!=null)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Incomplete");
            }

            if (b != null)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("incomplete");
            }

            if (c != null)
            {
                Console.WriteLine(c);

            }
            else
            {
                Console.WriteLine("incomplete");
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }

         static(int? cat1,int? cat2,int? cat3)?cats()
        {
            int? cat1 = 20;
            int? cat2 = 15;
            int? cat3 = 25;
            var result = Tuple.Create(cat1, cat2, cat3);
            return (cat1,cat2,cat3);

        }

        
        
            static (int? lab1, int? lab2, int? lab3)? labs()
        { 
            int? lab1 =null;
            int? lab2 = 11;
            int? lab3 = 14;
            return (lab1, lab2, lab3);
        }

    static (int? exam1, int? exam2, int? exam3,int? exam4,int? exam5,int? exam6)? mainexam()
    {
            int? exam1 = 60;
            int? exam2 = 65;
            int? exam3 = 75;
            int? exam4 = 80;
            int? exam5 = 85;
            int? exam6 = 50;
        return (exam1, exam2, exam3, exam4, exam5, exam6);
    }
    }
}
