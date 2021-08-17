using System;
using System.Collections.Generic;
using Controller;
using Model;

namespace AvailabilityFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Control theControl = new Control();
            
            // Set up view and query user
            Console.WriteLine("CAMPSITE AVAILABILITY FINDER");
            Console.WriteLine("Enter ZIP code or City name of desired camping location");
            string location = Console.ReadLine();
            Console.WriteLine("Enter desired check-in date of stay:");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter desired check-out date of stay:");
            string endDate = Console.ReadLine();

            List<Campground> availableSites = theControl.CheckAvailable(location, startDate, endDate);

            Console.WriteLine("There are " + theControl.TotalReservable + " reservable sites and " + theControl.TotalFCFS +" first-come-first-serve sites available for your selected date(s).");

            Console.WriteLine("CAMPGROUND NAME            RESERVABLE              FCFS");
            //$$ work out formatting of this later
            foreach(Campground campground in availableSites)
            {
                Console.Write(campground.Name);
                Console.Write(" " + campground.ReservableCount);
                Console.Write(" " + campground.FcfsCount);
            }
        }
    }
}
