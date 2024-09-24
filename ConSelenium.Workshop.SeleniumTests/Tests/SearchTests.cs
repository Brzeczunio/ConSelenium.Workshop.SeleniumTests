using FluentAssertions.Execution;
using ConSelenium.Workshop.SeleniumTests.Tests.Base;
using ConSelenium.Workshop.SeleniumTests.Pages;
using FluentAssertions;
using Allure.NUnit;

namespace ConSelenium.Workshop.SeleniumTests.Tests
{
    [AllureNUnit]
    public class SearchTests : BaseTest
    {
        [Test]
        public void WhenUserSearchsShirts_ThenShirtsShouldBeDisplayed()
        {
            var homePage = new HomePage(Driver);
            homePage.GoTo();
            homePage.SearchInput.SendKeys("koszula");
            homePage.FindButton.Click();

            var searchResultPage = new SearchResultPage(Driver);
            var searchItems = searchResultPage.SearchItems.GetItems();

            using (new AssertionScope())
            {
                searchItems.All(x => x.GetAttribute("title").Contains("Koszula", StringComparison.InvariantCultureIgnoreCase)).Should().BeTrue();
                searchItems.Count().Should().Be(6);
            }
        }
    }
}
