using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class OrderSubmitPage : BasePage
    {
        public Button OrderSubmitButton;

        public OrderSubmitPage(IWebDriver driver) : base(driver)
        {
            OrderSubmitButton = new Button(driver, By.Id("reg_submit"));
        }
    }
}
