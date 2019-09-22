using System;
using System.Diagnostics;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname;
            Console.WriteLine("enter your name");
           myname = Console.ReadLine();
            if (myname == "Eric".ToLower()||myname=="Eric".ToUpper()|| myname == "Eric")
            {
                Process myprocess = new Process();
                myprocess.StartInfo.FileName = "mspaint.exe";
                myprocess.StartInfo.Arguments = "\"C:\\Users\\Eric\\Pictures\\Camera Roll\\IMG_20170906_111532.jpg\"";
                myprocess.Start();
            }
            else
            {
                Console.WriteLine("exit");
            }
        }
    }
}
