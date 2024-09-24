using ConSelenium.Workshop.SeleniumTests.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConSelenium.Workshop.SeleniumTests.Elements
{
    public class Select
    {
        private IWebDriver _driver;
        private By _by;

        public Select(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public void SelectByValue(string value) => new SelectElement(_driver.WaitForElementExists(_by)).SelectByValue(value);
    }
}
