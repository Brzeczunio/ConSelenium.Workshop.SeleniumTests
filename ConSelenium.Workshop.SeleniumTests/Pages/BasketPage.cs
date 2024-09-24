using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class BasketPage : BasePage
    {
        public Button ContinueOrderButton;

        public BasketPage(IWebDriver driver) : base(driver)
        {
            ContinueOrderButton = new Button(driver, By.Id("reg_submit"));
        }
    }
}
