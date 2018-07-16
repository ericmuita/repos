using System;

namespace sum_of_even_and__product_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum, product;
            number = 20; sum = 0; product = 1;
            while (number <= 50)
            {
                if (number % 2 == 0)
                {
                    sum = number;
                }
                else if (number % 2 != 0)
                {
                    product = number;
                }
            }
                number++;
                Console.WriteLine("the sum of all even numbers is {0}",sum);
                Console.WriteLine("the product of all odd numbers is {0}", product);
                Console.ReadKey();
        }
    }
}
