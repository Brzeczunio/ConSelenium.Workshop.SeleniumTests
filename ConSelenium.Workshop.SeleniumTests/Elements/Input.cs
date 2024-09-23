using OpenQA.Selenium;
using ConSelenium.Workshop.SeleniumTests.Extensions;

namespace ConSelenium.Workshop.SeleniumTests.Elements
{
    public class Input
    {
        private IWebDriver _driver;
        private By _by;

        public Input(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public void SendKeys(string text) => _driver.WaitForVisible(_by).SendKeys(text);
    }
}
