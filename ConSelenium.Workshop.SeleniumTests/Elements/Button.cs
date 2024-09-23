using OpenQA.Selenium;
using ConSelenium.Workshop.SeleniumTests.Extensions;

namespace ConSelenium.Workshop.SeleniumTests.Elements
{
    public class Button
    {
        private IWebDriver _driver;
        private By _by;

        public Button(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public void Click() => _driver.WaitForClickable(_by).Click();
    }
}
