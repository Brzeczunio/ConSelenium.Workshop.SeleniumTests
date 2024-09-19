using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ConSelenium.Workshop.SeleniumTests.Tests
{
    public class Tests
    {
        private ChromeDriver _driver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-search-engine-choice-screen");
            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void WhenUserSearchsShirts_ThenShirtsShouldBeDisplayed()
        {
            _driver.Navigate().GoToUrl("https://test10.bestseller.sklep.pl/");


            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5))
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };

            var findInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("findQuery")));
            findInput.SendKeys("koszula");

            var regPasswordInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("findButton")));
            regPasswordInput.Click();

            var products = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("productText")));

            using (new AssertionScope())
            {
                products.All(x => x.GetAttribute("title").Contains("Koszula", StringComparison.InvariantCultureIgnoreCase)).Should().BeTrue();
                products.Count().Should().Be(6);
            }
        }

        [Test]
        public void WhenUserCreatesAccount_ThenAccountShouldBeCreated()
        {
            _driver.Navigate().GoToUrl("https://test10.bestseller.sklep.pl/rejestracja.php");


            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5))
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };

            var acceptCookies = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("buttonLinkContent")));
            acceptCookies.Click();

            var nameInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_name")));
            nameInput.SendKeys("Jan");

            var surnameInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_surname")));
            surnameInput.SendKeys("Kowalski");

            var streetInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_street")));
            streetInput.SendKeys("Prosta");

            var housNumberInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_no")));
            housNumberInput.SendKeys("7");

            var postalCodeInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_post")));
            postalCodeInput.SendKeys("40-600");

            var cityInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_city")));
            cityInput.SendKeys("Warszawa");

            var provinceSelect = new SelectElement(wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@title='Proszę wybrać region']"))));
            provinceSelect.SelectByValue("3");

            var phoneNumerInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_phone")));
            phoneNumerInput.SendKeys("500600900");

            var userEmailInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_email")));
            userEmailInput.SendKeys($"xxx{Guid.NewGuid().ToString().Substring(8)}@wp.pl");

            var passwordInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_reg_password")));
            passwordInput.SendKeys("123QWE809ASD,/.zxc");

            var passwordConfInput = wait.Until(ExpectedConditions.ElementExists(By.Id("i_reg_passwordConf")));
            passwordConfInput.SendKeys("123QWE809ASD,/.zxc");

            var dataAcceptCheckbox = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("i_dataAccept")));
            dataAcceptCheckbox.Click();

            var shopRegCheckbox = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("i_shopReg")));
            shopRegCheckbox.Click();

            var submitButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("reg_submit")));
            submitButton.Click();

            var registeredText = wait.Until(ExpectedConditions.ElementExists(By.ClassName("pageTitle")));

            using (new AssertionScope())
            {
                registeredText.Text.Should().Be("Dziękujemy za rejestrację w naszym serwisie");
            }
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Close();
            _driver.Dispose();
        }
    }
}