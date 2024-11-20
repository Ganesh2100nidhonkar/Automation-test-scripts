using AT_Assignment_Project_GaneshNidhonkar.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AT_Assignment_Project_GaneshNidhonkar.Pages
{
    public class Basepage : UtilityClass
    {
        private IWebDriver driver;

        // Elements for navigation
        private By registerElement = By.XPath("//*[text()='Register']");
        private By loginElement = By.XPath("//*[text()='Log in']");
        private By wishlistElement = By.XPath("//*[@class='wishlist-label']");
        private By cartElement = By.XPath("//*[@class='cart-label']");
        private By searchBarElement = By.XPath("//*[@class='search-box-text ui-autocomplete-input']");
        private By searchButtonElement = By.XPath("//*[@class='button-1 search-box-button']");

        public Basepage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Method to navigate to the register page
        public RegisterPage GoToRegisterPage()
        {
            IWebElement registerLink = driver.FindElement(registerElement);
            registerLink.Click();
            return new RegisterPage(driver);
        }

        // Method to navigate to the login page
        public LoginPage GoToLoginPage()
        {
            IWebElement loginLink = driver.FindElement(loginElement);
            loginLink.Click();
            return new LoginPage(driver);
        }

        // Method to enter text into the search bar
        public void EnterSearchText(string searchText)
        {
            IWebElement searchBar = driver.FindElement(searchBarElement);
            searchBar.Clear();
            searchBar.SendKeys(searchText);
        }

        // Method to click the search button
        public void ClickSearchButton()
        {
            IWebElement searchButton = driver.FindElement(searchButtonElement);
            searchButton.Click();
        }
    }
}
