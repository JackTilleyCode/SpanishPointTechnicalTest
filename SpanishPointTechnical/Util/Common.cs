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

        public void IsElementPresent(By by)
        {
            Assert.IsTrue(_driver.FindElement(by).Displayed);
        }
        public void InputElementValue(By by, string input)
        {
            _driver.FindElement(by).SendKeys(input);
            Debug.Print(TestContext.CurrentContext.Test + ":" + by.ToString() + " -> " + input);
        }
        public void IsElementPresent(string elementText)
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("//*[contains(text(),'" + elementText + "')]")).Displayed);
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
        }


        internal void ClickElement(By by)
        {
            var wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            element.Click();
            Debug.Print(TestContext.CurrentContext.Test + ":" + by.ToString() + " -> Click");
        }

        internal void IsElementNotPresent(string elementText)
        {
            Assert.IsTrue(_driver.FindElements(By.XPath("//*[contains(text(),'" + elementText + "')]")).Count == 0);
        }

        internal void ClearElement(By by)
        {
            _driver.FindElement(by).Clear();
        }
    }
}

