using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = "eric";
            Console.WriteLine("Please enter your username");
            string username=Console.ReadLine();
            Console.WriteLine("Please enter your phone number");
            string phonenumber = Console.ReadLine();
            if (phonenumber.StartsWith("+254")&&phonenumber.Length.Equals(13))
            {
                Console.WriteLine("you will receive a 6 digit verification code");
            }
            else
            {
                Console.WriteLine("wrong credentials");

            }
            var Verificationcode = new Random();
            var verificationcode = Verificationcode.Next(1000000);
            var Password=new Random();
            var password = Password.Next(1000000);
            Console.WriteLine(verificationcode);
            Console.WriteLine(password);
            Console.ReadKey();
            


        }

        public delegate void sms();

        public void SMS(sms a)
        {

        }
    }
}
