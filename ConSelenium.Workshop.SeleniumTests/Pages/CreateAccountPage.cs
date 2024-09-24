using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class CreateAccountPage : BasePage
    {
        public Button WithoutRegistartionButton;

        public CreateAccountPage(IWebDriver driver) : base(driver)
        {
            WithoutRegistartionButton = new Button(driver, By.XPath(".//a[@class='btn btn-primary']"));
        }
    }
}
