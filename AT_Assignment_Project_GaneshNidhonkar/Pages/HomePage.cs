using AT_Assignment_Project_GaneshNidhonkar.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_GaneshNidhonkar.Pages
{
    public class HomePage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //Creating Elements
        private By Myaccountelement = By.XPath("//*[text()='My account']");
        private By logoutelement = By.XPath("//*[text()='Log out']");
        private By Wishlistelement = By.XPath("//*[@class=\"wishlist-label\"]");
        private By cartelement = By.XPath("//*[@class=\"cart-label\"]");
        private By searchBarelement = By.XPath("//*[@class=\"search-box-text ui-autocomplete-input\"]");
        private By searchButtonlement = By.XPath("//*[@class=\"button-1 search-box-button\"]");
        

        //Creating Constructor
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Creating Custom Methods
        public AccountPage ClickMyAccount()
        {
            IWebElement clickMyAccountElement = driver.FindElement(Myaccountelement);
            clickMyAccountElement.Click();
            return new AccountPage(driver);
        }
        public Basepage Clicklogout()
        {
            IWebElement clickMyAccountElement = driver.FindElement(Myaccountelement);
            clickMyAccountElement.Click();
            return new Basepage(driver);
        }
        public void EnterSearch(string searchvalue)
        {
            IWebElement entersearchBarElement = driver.FindElement(searchBarelement);
            entersearchBarElement.SendKeys(searchvalue);
        }
        public SearchPage Clicksearchbutton()
        {
            IWebElement clicksearchbuttonElement = driver.FindElement(searchButtonlement);
            clicksearchbuttonElement.Click();
            return new SearchPage(driver);
        }


    }
}
