using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConfusedFramework
{
    public class Utilities
    {
        public static void Wait()
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
        }
    }
}
