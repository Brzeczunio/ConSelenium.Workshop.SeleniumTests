using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class HomePage : BasePage
    {
        public Input SearchInput;
        public Button FindButton;

        public HomePage(IWebDriver driver) : base(driver)
        {
            SearchInput = new Input(driver, By.Id("findQuery"));
            FindButton = new Button(driver, By.Id("findButton"));
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }
    }
}
