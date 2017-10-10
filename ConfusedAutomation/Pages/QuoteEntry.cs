using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConfusedFramework
{
    public class QuoteEntry
    {
        public static void GoTo()
        {
            /*TEST*/
            Driver.Instance.Navigate().GoToUrl("https://confusedlifetest2.directlife.co.uk");
            /*LIVE*/
            //driver.Navigate().GoToUrl("https://life.confused.com");
        }

        public static void LevelTerm()
        {
            var level = Driver.Instance.FindElement(By.XPath("//LABEL[@for='PolicyType-1'][text()='Life insurance']/self::LABEL"));
            level.Click();
        }

        public static void PolicyTerm()
        {
            var term = Driver.Instance.FindElement(By.Id("Term"));
        }

    }
}
