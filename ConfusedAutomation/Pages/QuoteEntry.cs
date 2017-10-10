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

        public static void PolicyTypeLevelTerm()
        {
            var level = Driver.Instance.FindElement(By.XPath("//LABEL[@for='PolicyType-1'][text()='Life insurance']/self::LABEL"));
            level.Click();
        }

        public static void PolicyTerm(string v)
        {
            var term = Driver.Instance.FindElement(By.Id("Term"));
            term.SendKeys(v);
        }

        public static void SumAssured(string v)
        {
            var sum = Driver.Instance.FindElement(By.Id("SumAssured"));
            sum.SendKeys(v);
        }

        public static void TitleMr()
        {
            var title = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_AppTitle-1'][text()='Mr']"));
            title.Click();
        }

        public static void App1FirstName(string v)
        {
            var firstName1 = Driver.Instance.FindElement(By.Id("Applicant1_Forename"));
            firstName1.SendKeys(v);
        }

        public static void App1Surname(string v)
        {
            var surname1 = Driver.Instance.FindElement(By.Id("Applicant1_Surname"));
            surname1.SendKeys(v);
        }



    }
}
