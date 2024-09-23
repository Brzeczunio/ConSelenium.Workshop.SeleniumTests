using ConSelenium.Workshop.SeleniumTests.Extensions;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Elements
{
    public class SearchItems
    {
        private IWebDriver _driver;
        private By _by;

        public SearchItems(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public IEnumerable<IWebElement> GetItems() => _driver.WaitForPresenceOfAllElements(_by);
    }
}
