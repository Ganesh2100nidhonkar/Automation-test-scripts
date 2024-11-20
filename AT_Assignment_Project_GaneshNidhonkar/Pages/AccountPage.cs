using AT_Assignment_Project_GaneshNidhonkar.Config;
using AT_Assignment_Project_GaneshNidhonkar.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AT_Assignment_Project_GaneshNidhonkar.Pages
{
    public class AccountPage : ConfigClass
{
    // Declaring IWebDriver
    private IWebDriver driver;

    // Creating Elements
    private By firstNameTextboxElement = By.XPath("//*[@id='FirstName']");
    private By lastNameTextboxElement = By.XPath("//*[@id='LastName']");
    private By saveButtonElement = By.XPath("//*[@name='save']");
    private By oldPasswordTextboxElement = By.XPath("//*[@id='OldPassword']");
    private By newPasswordTextboxElement = By.XPath("//*[@id='NewPassword']");
    private By confirmPasswordTextboxElement = By.XPath("//*[@id='ConfirmPassword']");
    private By changePasswordButtonElement = By.XPath("//*[@name='ChangePassword']");
    private By successMessageElement = By.XPath("//*[contains(@class, 'result')]");

        // Creating Constructor
        public AccountPage(IWebDriver driver)
    {
           this.driver = driver;
    }

    // Creating Custom Methods
    public void EnterFirstName(string firstName)
    {
        IWebElement firstNameElement = driver.FindElement(firstNameTextboxElement);
        firstNameElement.Clear();
        firstNameElement.SendKeys(firstName);
    }

        public void ClickSaveButton()
        {
            IWebElement saveButtonElement = driver.FindElement(this.saveButtonElement);
            saveButtonElement.Click();
        }

 
        public void SaveChanges()
        {
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@name='save']"));
            saveButton.Click();
        }
        public void EnterOldPassword(string oldPassword)
        {
            IWebElement oldPasswordElement = driver.FindElement(oldPasswordTextboxElement);
            oldPasswordElement.Clear();
            oldPasswordElement.SendKeys(oldPassword);
        }

        public void EnterNewPassword(string newPassword)
        {
            IWebElement newPasswordElement = driver.FindElement(newPasswordTextboxElement);
            newPasswordElement.Clear();
            newPasswordElement.SendKeys(newPassword);
        }

        public void EnterConfirmPassword(string confirmPassword)
        {
            IWebElement confirmPasswordElement = driver.FindElement(confirmPasswordTextboxElement);
            confirmPasswordElement.Clear();
            confirmPasswordElement.SendKeys(confirmPassword);
        }

        public void ClickChangePasswordButton()
        {
            IWebElement changePasswordButton = driver.FindElement(changePasswordButtonElement);
            changePasswordButton.Click();
        }
        // Method to get the success message
        public string GetSuccessMessage()
        {
            IWebElement messageElement = driver.FindElement(successMessageElement);
            return messageElement.Text;
        }

    }
}