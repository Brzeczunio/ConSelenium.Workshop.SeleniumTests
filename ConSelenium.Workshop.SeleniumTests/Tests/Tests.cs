using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ConSelenium.Workshop.SeleniumTests.Tests
{
    public class Tests
    {
        private ChromeDriver _driver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-search-engine-choice-screen");
            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void WhenUserSearchsShirts_ThenShirtsShouldBeDisplayed()
        {
            _driver.Navigate().GoToUrl("https://test10.bestseller.sklep.pl/");


            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5))
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };

            var findInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("findQuery")));
            findInput.SendKeys("koszula");

            var regPasswordInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("findButton")));
            regPasswordInput.Click();

            var products = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("productText")));

            using (new AssertionScope())
            {
                products.All(x => x.GetAttribute("title").Contains("Koszula", StringComparison.InvariantCultureIgnoreCase)).Should().BeTrue();
                products.Count().Should().Be(6);
            }
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Close();
            _driver.Dispose();
        }
    }
}