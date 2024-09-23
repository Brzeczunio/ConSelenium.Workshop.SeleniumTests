using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace ConSelenium.Workshop.SeleniumTests.Extensions
{
    internal static class WaitExtension
    {
        public static WebDriverWait Wait(this IWebDriver driver, int timeInSeconds = 5, int poolingInterval = 500)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(timeInSeconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(poolingInterval),
            };
        }

        public static IWebElement WaitForClickable(this IWebDriver driver, By by)
        {
            return driver.Wait().Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static IWebElement WaitForVisible(this IWebDriver driver, By by)
        {
            return driver.Wait().Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static IWebElement WaitForElementExists(this IWebDriver driver, By by)
        {
            return driver.Wait().Until(ExpectedConditions.ElementExists(by));
        }

        public static IEnumerable<IWebElement> WaitForPresenceOfAllElements(this IWebDriver driver, By by)
        {
            return driver.Wait().Until<IEnumerable<IWebElement>>(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

        public static IWebElement WaitForClickable(this IWebDriver driver, IWebElement element)
        {
            return driver.Wait().Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
