using System;
using Controller;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvailabilityFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // VIEW
            Console.WriteLine("CAMPSITE AVAILABILITY FINDER");
            Console.WriteLine("Enter desired check-in date of stay:");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter desired check-out date of stay:");
            string endDate = Console.ReadLine();

            // the view will invoke methods of the controller, controller will report info to be outputted in view via events
            Control.CheckAvailable(startDate, endDate);

        }
    }
}
