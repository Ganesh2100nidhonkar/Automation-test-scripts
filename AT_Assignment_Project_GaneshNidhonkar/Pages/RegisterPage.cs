using AT_Assignment_Project_GaneshNidhonkar.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_GaneshNidhonkar.Pages
{
    public class RegisterPage : UtilityClass
    {
        // Declaring IWebDriver
        private IWebDriver driver;

        // Creating Elements
        private By firstNameTextboxElement = By.Id("FirstName");
        private By lastNameTextboxElement = By.Id("LastName");
        private By emailTextboxElement = By.Id("Email");
        private By passwordTextboxElement = By.Id("Password");
        private By confirmPasswordTextboxElement = By.Id("ConfirmPassword");
        private By registerButtonElement = By.Id("register-button");
        private By registrationResultElement = By.ClassName("result");
        private By emailExistsErrorElement = By.XPath("//div[contains(text(), 'The specified email already exists')]");
        private By passwordMismatchErrorElement = By.XPath("//div[contains(text(), 'The password and confirmation password do not match')]");

        // Creating Constructor
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Creating Custom Methods
        public void EnterFirstName(string firstName)
        {
            IWebElement firstNameElement = driver.FindElement(firstNameTextboxElement);
            firstNameElement.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            IWebElement lastNameElement = driver.FindElement(lastNameTextboxElement);
            lastNameElement.SendKeys(lastName);
        }

        public void EnterEmail(string email)
        {
            IWebElement emailElement = driver.FindElement(emailTextboxElement);
            emailElement.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            IWebElement passwordElement = driver.FindElement(passwordTextboxElement);
            passwordElement.SendKeys(password);
        }

        public void EnterConfirmPassword(string confirmPassword)
        {
            IWebElement confirmPasswordElement = driver.FindElement(confirmPasswordTextboxElement);
            confirmPasswordElement.SendKeys(confirmPassword);
        }

        public void ClickRegister()
        {
            IWebElement registerButton = driver.FindElement(registerButtonElement);
            registerButton.Click();
        }

        public string GetRegistrationResult()
        {
            IWebElement registrationResult = driver.FindElement(registrationResultElement);
            return registrationResult.Text;
        }
        // Method to get email exists error message
        public string GetEmailExistsErrorMessage()
        {
            IWebElement errorElement = driver.FindElement(emailExistsErrorElement);
            return errorElement.Text;
        }

        // Method to get password mismatch error message
        public string GetPasswordMismatchErrorMessage()
        {
            IWebElement errorElement = driver.FindElement(passwordMismatchErrorElement);
            return errorElement.Text;
        }
    }
}