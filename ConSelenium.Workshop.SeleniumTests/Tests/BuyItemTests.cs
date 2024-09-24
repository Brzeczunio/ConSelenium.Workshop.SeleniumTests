using ConSelenium.Workshop.SeleniumTests.Tests.Base;
using FluentAssertions.Execution;
using FluentAssertions;
using ConSelenium.Workshop.SeleniumTests.Pages;
using Allure.NUnit;

namespace ConSelenium.Workshop.SeleniumTests.Tests
{
    [AllureNUnit]
    public class BuyItemTests : BaseTest
    {
        [Test]
        public void WhenUserBuyItem_ThenItemShouldBeBought()
        {
            var rollsPage = new RollsPage(Driver);
            rollsPage.GoTo();
            rollsPage.AcceptCookiesButton.Click();
            rollsPage.BaguetteImage.Click();

            var addProductPage = new AddProductPage(Driver);
            addProductPage.AddToBasketButton.Click();

            var basketPage = new BasketPage(Driver);
            basketPage.ContinueOrderButton.Click();


            var createAccountPage = new CreateAccountPage(Driver);
            createAccountPage.WithoutRegistartionButton.Click();

            var userDetailsPage = new UserDetailsPage(Driver);
            userDetailsPage.NameInput.SendKeys("Jan");
            userDetailsPage.SurnameInput.SendKeys("Kowalski");
            userDetailsPage.StreetInput.SendKeys("Prosta");
            userDetailsPage.HousNumberInput.SendKeys("7");
            userDetailsPage.PostalCodeInput.SendKeys("40-600");
            userDetailsPage.CityInput.SendKeys("Warszawa");
            userDetailsPage.ProvinceSelect.SelectByValue("3");
            userDetailsPage.PhoneNumerInput.SendKeys("500600900");
            userDetailsPage.DataAcceptCheckbox.Click();
            userDetailsPage.ShopRegCheckbox.Click();
            userDetailsPage.UserEmailInput.SendKeys($"xxx{Guid.NewGuid().ToString().Substring(0, 5)}@wp.pl");
            userDetailsPage.FormSubmitButton.Click();

            var orderSubmitPage = new OrderSubmitPage(Driver);
            orderSubmitPage.OrderSubmitButton.Click();

            var orderSummaryPage = new OrderSummaryPage(Driver);

            using (new AssertionScope())
            {
                orderSummaryPage.SuccessfulPurchaseText.GetText().Should().Be("Dziękujemy");
            }
        }
    }
}
