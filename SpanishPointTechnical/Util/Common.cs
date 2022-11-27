using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SpanishPointTechnical.Util
{

    public class Common
    {
        ChromeDriver _driver;
        public Common(ChromeDriver driver)
        {
            _driver = driver;
        }

        internal string GetTextFromElement(By by)
        {
            var wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            return element.Text;
        }

        internal void HoverElement(By by)
        {
            WebElement ele = (WebElement)_driver.FindElement(By.XPath("//*[@id=\"menu-item-6191\"]/a/span"));
            Actions action = new Actions(_driver);
            action.MoveToElement(ele).Perform();
            Debug.Print(TestContext.CurrentContext.Test + ":" + by.ToString() + " -> Hover");
        }


        internal void ClickElement(By by)
        {
            var wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            element.Click();
            Debug.Print(TestContext.CurrentContext.Test + ":" + by.ToString() + " -> Click");
        }

    }
}

