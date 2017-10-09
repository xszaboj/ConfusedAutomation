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
            var level = Driver.Instance.FindElement(By.ClassName("replaced-input-label"));
            level.Click();
        }
    }
}
