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
            // $$ VIEW
            Console.WriteLine("CAMPSITE AVAILABILITY FINDER");
            Console.WriteLine("Enter desired check-in date of stay:");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter desired check-out date of stay:");
            string endDate = Console.ReadLine();

            // $$ the view will invoke methods of the controller, controller will report info to be outputted in view via events
            List<Campground> availableSites = Control.CheckAvailable(startDate, endDate);

            foreach(Campground campground in availableSites)
            {
                Console.WriteLine(campground.Name);
            }
        }
    }
}
