using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person carol = new Person();
           // carol.name = "Caroline";
            Child carol = new Child();
            Console.WriteLine(carol.name);
            Adult Ken = new Adult();
            int age = carol.minAge;
            if(age>=18)
            {
                Console.WriteLine("Allowed");
            }
            else
            {
                Console.WriteLine("Underage");
            }
            MeetUp.venue = "Nairobi";
            Console.WriteLine(MeetUp.venue);

        }
    }
      abstract class Person
        //Abstract classes cannot be instantiated
    {
        public int minAge { get; set; }
        public int height;
        public string name;
        public int YoB (int age)
        {
            int c = 2019 - age;
            return c;
        }
       /* public Person()
        {
            name = "unknown";
        }*/
    }
    class Child:Person
    {
        public Child()
        {
            minAge = 0;
        }

    }
    class Adult:Person
    {
        public Adult()
        {
            minAge = 18;
        }

    }
    static class MeetUp
        //note:static classes have no constructors
    {
        public static string venue { get; set; }
        
        
    }
}
