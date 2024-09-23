using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class RegisterPage : BasePage
    {
        public Input NameInput;
        public Input SurnameInput;
        public Input StreetInput;
        public Input HousNumberInput;
        public Input PostalCodeInput;
        public Input CityInput;
        public Input PhoneNumerInput;
        public Input UserEmailInput;
        public Input PasswordInput;
        public Input PasswordConfInput;

        public Select ProvinceSelect;

        public CheckBox DataAcceptCheckbox;
        public CheckBox ShopRegCheckbox;

        public Button AcceptCookiesButton;
        public Button SubmitButton;

        public RegisterPage(IWebDriver driver) : base(driver)
        {
            NameInput = new Input(driver, By.Id("i_name"));
            SurnameInput = new Input(driver, By.Id("i_surname"));
            StreetInput = new Input(driver, By.Id("i_street"));
            HousNumberInput = new Input(driver, By.Id("i_no"));
            PostalCodeInput = new Input(driver, By.Id("i_post"));
            CityInput = new Input(driver, By.Id("i_city"));
            PhoneNumerInput = new Input(driver, By.Id("i_phone"));
            UserEmailInput = new Input(driver, By.Id("i_email"));
            PasswordInput = new Input(driver, By.Id("i_reg_password"));
            PasswordConfInput = new Input(driver, By.Id("i_reg_passwordConf"));

            ProvinceSelect = new Select(driver, By.XPath(".//*[@title='Proszę wybrać region']"));

            DataAcceptCheckbox = new CheckBox(driver, By.Id("i_dataAccept"));
            ShopRegCheckbox = new CheckBox(driver, By.Id("i_shopReg"));

            AcceptCookiesButton = new Button(driver, By.ClassName("buttonLinkContent"));
            SubmitButton = new Button(driver, By.Id("reg_submit"));
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl(BASE_URL + "rejestracja.php");
        }
    }
}
