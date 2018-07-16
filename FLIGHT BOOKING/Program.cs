using System;
using static System.Console;

namespace FLIGHT_BOOKING
{
    class Program
    {
        static void Main(string[] args)
        {
            Userinput();
            ReadKey();
        }
        static void Userinput()
        {
            string name, destination, category, countryofresidence;
            int passport;
            decimal amount = 5534566;
            Flight book = new Flight();
            WriteLine("enter your name");
            book.Nameofcustomer = ReadLine();
            WriteLine("enter your passport number");
            book.Passport = int.Parse(ReadLine());
            WriteLine("enter your destination");
            book.Destination = ReadLine();
            WriteLine("enter your date");
            book.Departure = Convert.ToDateTime(ReadLine());
            WriteLine("enter your category");
            book.Category = ReadLine();
            WriteLine("enter your country of residence");
            book.Countryofresidence = ReadLine();
            WriteLine("book a return flight");
            book.returnhome = bool.Parse(ReadLine());
            WriteLine("the flight has been successfully booked ");
            Clear();
            WriteLine("Name:"+book.Nameofcustomer);
            WriteLine("Passport:"+book.Passport);
            WriteLine("Amount:"+amount);
            WriteLine("Destination:"+book.Destination);
            WriteLine("Departure:"+book.Departure);
            
           


        }
    }
}
