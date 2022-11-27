using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SpanishPointTechnical.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishPointTechnical.PageObjects
{
    public class HomePage
    {
        ChromeDriver _driver;
        private Common util => new Common(_driver);

        public HomePage(ChromeDriver driver)
        {
            _driver = driver;
        }

        internal void GoToHomePage()
        {
            _driver.Navigate().GoToUrl("https://www.spanishpoint.ie/");
        }

        internal void ClickAcceptAllCookies()
        {
            util.ClickElement(By.Id("wt-cli-accept-btn"));     
        }

        internal void HoverOverSolutionServices()
        {
            util.HoverElement(By.XPath("//*[@id=\"menu-item-6191\"]/a/span"));
        }

        internal void ClickModernWork()
        {
            util.ClickElement(By.XPath("//*[@id=\"menu-item-23119\"]/a"));       
        }

    }
}
