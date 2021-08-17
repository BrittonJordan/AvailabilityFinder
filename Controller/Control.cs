using Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class Control
    {
        public int TotalReservable { get; private set; }
        public int TotalFCFS { get; private set; }
        public int TotalSites { get; private set; }

        public List<Campground> CheckAvailable(string location, string startDate, string endDate)
        {
            List<Campground> campgrounds = new List<Campground>();

            string startDateURL = startDate.Substring(0, 2) + "%2F" + startDate.Substring(3, 2) + "%2F" + startDate.Substring(6, 4);
            string endDateURL = endDate.Substring(0, 2) + "%2F" + endDate.Substring(3, 2) + "%2F" + endDate.Substring(6, 4);
            string recGovURL = "https://www.recreation.gov/search?q=" + location + "&inventory_type=camping&sort=available&checkin=" + startDateURL + "&checkout=" + endDateURL;
            
            using (var driver = new ChromeDriver())
            {
                // https://www.recreation.gov/search?q=84405&inventory_type=camping&sort=available&checkin=08%2F06%2F2021&checkout=08%2F07%2F2021
                driver.Url = recGovURL;
                driver.Navigate().GoToUrl(recGovURL);
                driver.Manage().Window.Maximize();


                //while ()
                //{

                //}
                //var dateField = driver.FindElementById("single-date-picker-1");
                //dateField.SendKeys(Keys.Left);
                //dateField.SendKeys(Keys.Backspace);
                //dateField.SendKeys("08/04/2021");
                //driver.Navigate().
                Console.Read();
            }


            return campgrounds;
        }
    }
}
