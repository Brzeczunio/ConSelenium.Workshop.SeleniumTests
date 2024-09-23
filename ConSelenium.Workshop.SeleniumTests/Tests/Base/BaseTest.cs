using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Tests.Base
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-search-engine-choice-screen");
            Driver = new ChromeDriver(options);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            Driver.Close();
            Driver.Dispose();
        }
    }
}
