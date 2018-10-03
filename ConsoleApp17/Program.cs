using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Results.Cat = 2;
            Results.Mainexam = 8;
            Results.Labs = 3;
            double? mainExamPapers = Results.Cat ?? null;
            double? allcats = Results.Mainexam ?? null;
            double? alllabs = Results.Labs??null;
            var all = Results.Cat.ToString() ?? Results.Labs.ToString() ?? Results.Mainexam.ToString() ?? "Incomplete";
            Console.ReadKey();
        }
    }

    public static class Results
    {
        public static double? Cat { get; set; }
        public static double? Mainexam { get; set; }
        public static double? Labs { get; set; }
    }
}
