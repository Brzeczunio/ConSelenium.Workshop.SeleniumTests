using ConSelenium.Workshop.SeleniumTests.Elements;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages.Base
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        public Button AcceptCookiesButton;

        protected const string BASE_URL = "https://test10.bestseller.sklep.pl/";

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
            AcceptCookiesButton = new Button(driver, By.ClassName("buttonLinkContent"));
        }

        public string GetUrl()
        {
            return driver.Url;
        }
    }
}
