using AT_Assignment_Project_GaneshNidhonkar.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_GaneshNidhonkar.Pages
{
    public class LoginPage : UtilityClass 
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //Creating Elements
        private By emailTextboxElement = By.XPath("//*[@name = 'Email']");
        private By passwordTextboxElement = By.XPath("//*[@name='Password']");
        private By loginButtonElement = By.XPath("//*[@class=\"button-1 login-button\"]");

        //Creating Constructor
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Creating Custom Methods
        public void EnterEmail(string emailValue)
        {
            IWebElement enterEmailElement = driver.FindElement(emailTextboxElement);
            enterEmailElement.SendKeys(emailValue);
        }

        public void EnterPassword(string passwordValue)
        {
            IWebElement enterPasswordElement = driver.FindElement(passwordTextboxElement);
            enterPasswordElement.SendKeys(passwordValue);
        }
        public HomePage ClickLogin()
        {
            IWebElement clickLoginElement = driver.FindElement(loginButtonElement);
            clickLoginElement.Click();
            return new HomePage(driver);
        }

    }
}
