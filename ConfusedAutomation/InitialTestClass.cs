using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfusedAutomation
{
    public class InitialTestClass
    {
        public void Go()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://confusedlifetest2.directlife.co.uk");
        }
    }
}
