using System;
using System.Collections.Generic;
using System.Text;

namespace EXPENDITURE_APPLICATION
{
    public  class usage
    {
        public double Food{get;set;}
        public double Rent { get; set; }
        public double Clothing { get; set; }
        public double Transport { get; set; }
        public double Electricity { get; set; }
        public double Water { get; set; }

        public usage()
        {
            Food = 100;
            Rent = 1500;
            Clothing = 300;
            Transport = 400;
            Electricity = 600;
            Water = 950;
                
        }
    }
}
