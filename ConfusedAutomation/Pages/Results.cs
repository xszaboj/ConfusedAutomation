using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConfusedFramework
{
    public class Results
    {
        public static void ApplyRoyalLondon()
        {
            var royalLondon = Driver.Instance.FindElement(By.CssSelector("tr[data-provider-code^='RLG'] > td.result__td--action > a"));

        }
    }
}
