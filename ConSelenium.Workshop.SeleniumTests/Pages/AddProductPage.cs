using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class AddProductPage : BasePage
    {
        public Button AddToBasketButton;

        public AddProductPage(IWebDriver driver) : base(driver)
        {
            AddToBasketButton = new Button(driver, By.Id("addToBasket"));
        }
    }
}
