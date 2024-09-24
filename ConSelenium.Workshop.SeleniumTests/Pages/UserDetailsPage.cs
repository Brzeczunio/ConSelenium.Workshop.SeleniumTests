using ConSelenium.Workshop.SeleniumTests.Elements;
using ConSelenium.Workshop.SeleniumTests.Pages.Base;
using OpenQA.Selenium;

namespace ConSelenium.Workshop.SeleniumTests.Pages
{
    public class UserDetailsPage : BasePage
    {
        public Input NameInput;
        public Input SurnameInput;
        public Input StreetInput;
        public Input HousNumberInput;
        public Input PostalCodeInput;
        public Input CityInput;
        public Input PhoneNumerInput;
        public Input UserEmailInput;

        public Select ProvinceSelect;

        public CheckBox DataAcceptCheckbox;
        public CheckBox ShopRegCheckbox;

        public Button FormSubmitButton;

        public UserDetailsPage(IWebDriver driver) : base(driver)
        {
            NameInput = new Input(driver, By.Id("i_name"));
            SurnameInput = new Input(driver, By.Id("i_surname"));
            StreetInput = new Input(driver, By.Id("i_street"));
            HousNumberInput = new Input(driver, By.Id("i_no"));
            PostalCodeInput = new Input(driver, By.Id("i_post"));
            CityInput = new Input(driver, By.Id("i_city"));
            PhoneNumerInput = new Input(driver, By.Id("i_phone"));
            UserEmailInput = new Input(driver, By.Id("i_email"));

            ProvinceSelect = new Select(driver, By.XPath(".//*[@title='Proszę wybrać region']"));

            DataAcceptCheckbox = new CheckBox(driver, By.Id("i_dataAccept"));
            ShopRegCheckbox = new CheckBox(driver, By.Id("i_shopReg"));

            FormSubmitButton = new Button(driver, By.Id("reg_submit"));
        }
    }
}
