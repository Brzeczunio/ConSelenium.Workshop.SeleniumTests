using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class SearchResultPage: BasePage
    {
        public SearchItems SearchItems;

        public SearchResultPage(IWebDriver driver) : base(driver)
        {
            SearchItems = new SearchItems(driver, By.ClassName("productText"));
        }
    }
}
