using ConSelenium.Workshop.SeleniumTests.Extensions;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Elements
{
    public class Text
    {
        private IWebDriver _driver;
        private By _by;

        public Text(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public string GetText() => _driver.WaitForElementExists(_by).Text;
    }
}
