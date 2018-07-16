using System;
using System.Collections.Generic;
using System.Text;

namespace FLIGHT_BOOKING
{
    public class Flight
    {
        public string Flightname { get; set; }
        public string Destination { get; set; }
        public string Category { get; set; }
        public string Nameofcustomer { get; set; }
        public int Passport { get; set; }
        public decimal Amount { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public string Countryofresidence { get; set; }
        public bool returnhome { get; set; }
    }
}
