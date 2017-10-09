using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConfusedFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
        }
    }
}
