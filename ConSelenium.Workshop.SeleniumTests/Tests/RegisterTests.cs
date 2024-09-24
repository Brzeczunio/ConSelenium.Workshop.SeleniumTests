using ConSelenium.Workshop.SeleniumTests.Tests.Base;
using FluentAssertions.Execution;
using ConSelenium.Workshop.SeleniumTests.Pages;
using FluentAssertions;
using Allure.NUnit;

namespace ConSelenium.Workshop.SeleniumTests.Tests
{
    [AllureNUnit]
    public class RegisterTests : BaseTest
    {
        [Test]
        public void WhenUserCreatesAccount_ThenAccountShouldBeCreated()
        {
            var registerPage = new RegisterPage(Driver);
            registerPage.GoTo();
            registerPage.AcceptCookiesButton.Click();
            registerPage.NameInput.SendKeys("Jan");
            registerPage.SurnameInput.SendKeys("Kowalski");
            registerPage.StreetInput.SendKeys("Prosta");
            registerPage.HousNumberInput.SendKeys("7");
            registerPage.PostalCodeInput.SendKeys("40-600");
            registerPage.CityInput.SendKeys("Warszawa");
            registerPage.ProvinceSelect.SelectByValue("3");
            registerPage.PhoneNumerInput.SendKeys("500600900");
            registerPage.UserEmailInput.SendKeys($"xxx{Guid.NewGuid().ToString().Substring(0, 5)}@wp.pl");
            registerPage.PasswordInput.SendKeys("123QWE809ASD,/.zxc");
            registerPage.PasswordConfInput.SendKeys("123QWE809ASD,/.zxc");
            registerPage.DataAcceptCheckbox.Click();
            registerPage.ShopRegCheckbox.Click();
            registerPage.SubmitButton.Click();

            var registeredPage = new RegisteredPage(Driver);

            using (new AssertionScope())
            {
                registeredPage.RegisteredText.GetText().Should().Be("Dziękujemy za rejestrację w naszym serwisie");
            }
        }
    }
}
