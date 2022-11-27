using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpanishPointTechnical.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishPointTechnical.PageObjects
{
    public class ModernWorkPage
    {
        ChromeDriver _driver;
        private Common util => new Common(_driver);

        public ModernWorkPage(ChromeDriver driver)
        {
            _driver = driver;
        }
        internal void ClickEmployeeExperience()
        {
            IJavaScriptExecutor js = _driver;
            js.ExecuteScript("window.scrollBy(0,450)", "");
            util.ClickElement(By.XPath("/html/body/div[2]/div[1]/section/section/div[3]/div/div/div/div[2]/div/div[1]/ul/li[2]/a"));
        }

        internal void AssertParaStartsWithText(string startText)
        {
            string elementText = util.GetTextFromElement(By.XPath("//*[@id=\"1612869843368-c8e2f605-d38c\"]/div[2]/div/div[2]/div/div/div[1]/div"));
            Assert.AreEqual(elementText.Substring(0, 71), startText);
        }

        internal void AssertHeaderText(string headerText)
        {
            string elementText = util.GetTextFromElement(By.XPath("//*[@id=\"1612869843368-c8e2f605-d38c\"]/div[2]/div/div[2]/div/div/h3"));
            Assert.AreEqual(headerText, elementText);
        }
    }
}
