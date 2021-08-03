using System;
using OpenQA.Selenium.Chrome;

namespace AvailabilityFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver())
            {
                driver.Url = "https://www.recreation.gov/camping/campgrounds/233730/availability";
                driver.Navigate().GoToUrl("https://www.recreation.gov/camping/campgrounds/233730/availability");
                var dateField = driver.FindElementById("single-date-picker-1");
                dateField.Clear();
                //dateField.SendKeys("08/04/2021");
                Console.Read();
                //driver.Navigate().
            }


            Console.WriteLine("Hello World!");
        }
    }
}
