using ConSelenium.Workshop.SeleniumTests.Extensions;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Elements
{
    public class CheckBox
    {
        private IWebDriver _driver;
        private By _by;

        public CheckBox(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public void Click() => _driver.WaitForClickable(_by).Click();
    }
}
