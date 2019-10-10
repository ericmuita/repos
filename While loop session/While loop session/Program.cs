using System;
using System.Reflection.Emit;

namespace While_loop_session
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is the syntax for the while loop

           int x = 0;

           while (x<5)
           {
               Console.WriteLine("Hello world!");
           }

           //Here is the syntax for the do while loop

          do
          {
              Console.WriteLine(x);
              x++;
          } while (x<5);

            //Here is the syntax for the for loop

           for (int i = 0; i < 5; i++)
           {
               Console.WriteLine(i);
           }

           //Here is the syntax for the foreach loop

           string[] names = new string[5] {"Sam","Tony","Joy","Joe","Sandra" };
           foreach (string name in names)
           {
               Console.WriteLine(name);
           }

            //A simple login program
         

            
            string myUserName = "Eric";
            string myPassword = "ndegwa";
            string choice;
           
            do
            {
                int attempts = 3;
                while (attempts<=3 && attempts>-1)
                {
                    Console.WriteLine("Enter your Username");
                    string name = Console.ReadLine().ToLower();
                    Console.Clear();
                    Console.WriteLine("Enter your password");
                    string password = Console.ReadLine();
                    Console.Clear();
                    if (name!=myUserName.ToLower() || password!=myPassword)
                    {
                        Console.WriteLine($"Wrong Username or password ({attempts} attempts remaining)");

                        attempts--;
                        if (attempts==-1)
                        {
                            Console.WriteLine("You have exceeded three times!\n...........................");
                            goto theEnd;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hello {0} ,Welcome",name);
                        return;
                    }
                }
                theEnd:
                Console.WriteLine("Do you want to proceed?...Enter Yes or No");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                if (choice=="no")
                {
                    return;
                }
                else if (choice!="yes")
                {
                    Console.WriteLine("You have entered the wrong answer !\n..................\nPlease try again ");
                    goto theEnd;
                }
                
            } while (choice=="yes");
            
            

            





        }
    }
}
