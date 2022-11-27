using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using SpanishPointTechnical.PageObjects;

namespace SpanishPointTechnical.StepDefinitions
{
    [Binding]
    public class EmployeeExperienceStepDefinitions
    {
        private ChromeDriver _driver;

        HomePage homePage => new HomePage(_driver);
        ModernWorkPage modernWorkPage => new ModernWorkPage(_driver);

        [BeforeScenario]
        public void Init()
        {
            ChromeOptions options = new ChromeOptions();
            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
        }
        [AfterScenario]
        public void Dispose()
        {
            _driver.Quit();
        }

        [Given(@"On homepage")]
        public void GivenOnHomepage()
        {
            homePage.GoToHomePage();
        }

        [When(@"Click Accept all cookies")]
        public void WhenClickAcceptAllCookies()
        {
            homePage.ClickAcceptAllCookies();
        }

        [When(@"Hover Over Solution & Services")]
        public void WhenHoverOverSolutionServices()
        {
            homePage.HoverOverSolutionServices();
        }

        [When(@"Click Modern Work")]
        public void WhenClickModernWork()
        {
            homePage.ClickModernWork();
        }

        [When(@"Click Employee Experience tab")]
        public void WhenClickEmployeeExperienceTab()
        {
            modernWorkPage.ClickEmployeeExperience();
        }

        [Then(@"Assert Employee Experience details")]
        public void ThenAssertEmployeeExperienceDetails()
        {
            modernWorkPage.AssertParaStartsWithText("Engaging, Mobile Intranet and Digital Workspace collaboration solution.");
            modernWorkPage.AssertHeaderText("Employee Experience");
        }
    }
}
