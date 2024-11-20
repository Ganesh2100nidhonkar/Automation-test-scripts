using AT_Assignment_Project_GaneshNidhonkar.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using AT_Assignment_Project_GaneshNidhonkar.Utility;

namespace AT_Assignment_Project_GaneshNidhonkar.Steps
{
    [Binding]
    public class RegisterPageSteps : UtilityClass
    {
        private IWebDriver driver;
        private RegisterPage registerPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            
            driver = new ChromeDriver();
            registerPage = new RegisterPage(driver);
            registerPage.LaunchApp();
            registerPage.BrowserMaximize();
            registerPage.ImplicitWait();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"I am on the register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/register");
        }

        [When(@"I enter the following details")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {
            var data = table.Rows[0];
            registerPage.EnterFirstName(data["FirstName"]);
            registerPage.EnterLastName(data["LastName"]);
            registerPage.EnterEmail(data["Email"]);
            registerPage.EnterPassword(data["Password"]);
            registerPage.EnterConfirmPassword(data["ConfirmPassword"]);
        }

        [When(@"I click the register button")]
        public void WhenIClickTheRegisterButton()
        {
            registerPage.ClickRegister();
        }

        [Then(@"I should see the message ""(.*)""")]
        public void ThenIShouldSeeTheMessage(string expectedMessage)
        {
            var actualMessage = registerPage.GetRegistrationResult();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string expectedMessage)
        {
            string actualMessage = registerPage.GetEmailExistsErrorMessage();
            Assert.AreEqual(expectedMessage, actualMessage, "Error message did not match the expected message.");
        }

        [Then(@"I should see an error message ""(.*)""")]
        public void ThenIShouldSeeAnErrorMessage(string expectedMessage)
        {
            string actualMessage = registerPage.GetPasswordMismatchErrorMessage();
            Assert.AreEqual(expectedMessage, actualMessage, "Error message did not match the expected message.");
        }
    }
}