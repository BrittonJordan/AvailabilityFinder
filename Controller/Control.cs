using Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class Control
    {

        public static List<Campground> CheckAvailable(string startDate, string endDate)
        {
            using (var driver = new ChromeDriver())
            {
                driver.Url = "https://www.recreation.gov/camping/campgrounds/233730/availability";
                driver.Navigate().GoToUrl("https://www.recreation.gov/camping/campgrounds/233730/availability");
                var dateField = driver.FindElementById("single-date-picker-1");
                dateField.SendKeys(Keys.Left);
                dateField.SendKeys(Keys.Backspace);
                //dateField.SendKeys("08/04/2021");
                Console.Read();
                //driver.Navigate().
            }

            return null;
        }
    }
}
