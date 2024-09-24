using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class OrderSummaryPage : BasePage
    {
        public Text SuccessfulPurchaseText;

        public OrderSummaryPage(IWebDriver driver) : base(driver)
        {
            SuccessfulPurchaseText = new Text(driver, By.ClassName("pageTitle"));
        }
    }
}
