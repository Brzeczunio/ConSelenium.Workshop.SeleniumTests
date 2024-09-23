using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class RegisteredPage : BasePage
    {
        public Text RegisteredText;

        public RegisteredPage(IWebDriver driver) : base(driver)
        {
            RegisteredText = new Text(driver, By.ClassName("pageTitle"));
        }
    }
}
