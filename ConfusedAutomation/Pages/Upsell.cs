using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConfusedFramework
{
    public class Upsell
    {
        public static void IndexationYes()
        {
            var indexationYes = Driver.Instance.FindElement(By.Id("NoNullIsIndexed"));
            indexationYes.Click();
        }

        public static void ClickContinueButton()
        {
            var continueButton = Driver.Instance.FindElement(By.ClassName("btn"));
            continueButton.Click();
        }
    }
}
