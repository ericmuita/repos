using System;
using System.Runtime;

namespace type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //booking of a room,use enums eg large or small,convert number of days to hours ,according to size,
            //number of people in that room,days to stay,meals to take
            //calculate per meal,per night stay,method to do totals depending on meals 
            Console.WriteLine("Enter the size of room to book");
            var choice = Console.ReadLine();
            Console.Clear();
            if (choice == "large" || choice == "Large")
            {
               Console.WriteLine(size.large);//use of enums
            }
            else if (choice == "small" || choice == "Small")
            {
                Console.WriteLine(size.small);//use of enums
            }
            Console.WriteLine("enter the number of people");
            int NumberOfPeople = Convert.ToInt32(Console.ReadLine());
            double numberofpeople = (double) NumberOfPeople;//casting
            Console.Clear();
            Console.WriteLine(numberofpeople);
            Console.WriteLine("enter the number of days and number of meals");
            var NumberOfDaysandmeals = booking();
            Console.WriteLine(NumberOfDaysandmeals);
            var costofmeal = booking().Value.meals * 200;
            Console.WriteLine(costofmeal);
            var costofdays = booking().Value.days * 500;
            var totalcost = costofmeal + costofdays;
            Console.WriteLine(totalcost);
            Console.ReadKey();
        }

        static (int? meals,int? days)? booking()
        {
            
            int? meals = Convert.ToInt32(Console.ReadLine());
            int? days = Convert.ToInt32(Console.ReadLine());
            return (meals,days);

        }

        enum size
        {
          small,large  
        }
    }
}
