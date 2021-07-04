using System;
using System.Collections.Generic;

namespace Dictonaries
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //states.Add("AZ", "Arizona");
            //states.Add("FL", "Florida");
            //states.Add("TX", "Texas");
            //states.Add("WA", "Washington");
            //states.Add("NM", "New Mexico");
            //Console.WriteLine(states);
            var states = new Dictionary<string, string>()
            {
                {"ca", "california"},
                {"wa","washington"},
                {"tx","texas"},
                {"fl","florida"},
                {"nm","new mexico"},
            };
            Console.WriteLine(states);

            //var vendors = new Dictionary<string, Vendor>()
            //{
            //    {"abc",new Vendor()
            //    {VendoriID=1,CompanyName="Murder Inc",Email="murderinc@murder.com" } },

            //    {"def",new Vendor()
            //    {VendoriID=1,CompanyName="Murder Inc",Email="murderinc@murder.com" } },
            //};
            //Console.WriteLine(vendors);
            //return vendors;
        }

        
    }

    //public class Vendor
    //{
    //    //public Vendor()
    //    //{
    //    //}

    //    //public int VendoriID { get; set; }
    //    //public string CompanyName { get; set; }
    //    //public string Email { get; set; }
    //}
}
