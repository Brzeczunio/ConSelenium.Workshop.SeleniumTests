using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class RollsPage : BasePage
    {
        public Button BaguetteImage;

        public RollsPage(IWebDriver driver) : base(driver)
        {
            BaguetteImage = new Button(driver, By.XPath(".//img[@alt='Bagietka francuska']"));
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl(BASE_URL + "buleczki,21,0.html");
        }
    }
}
