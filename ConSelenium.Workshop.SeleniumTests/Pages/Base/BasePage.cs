using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages.Base
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        protected const string BASE_URL = "https://test10.bestseller.sklep.pl/";

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetUrl()
        {
            return driver.Url;
        }
    }
}
