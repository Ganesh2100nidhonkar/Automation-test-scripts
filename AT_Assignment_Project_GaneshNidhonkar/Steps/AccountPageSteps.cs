using AT_Assignment_Project_GaneshNidhonkar.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace AT_Assignment_Project_GaneshNidhonkar.Steps
{
    [Binding]
    public class AccountPageSteps
    {
        private IWebDriver driver;
        private AccountPage accountPage;




        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new EdgeDriver(@"C:\Users\ganesh.nidhonkar\source\repos\AT_Assignment_Sol_GaneshNidhonkar\AT_Assignment_Project_GaneshNidhonkar\Drivers\msedgedriver.exe");
            accountPage = new AccountPage(driver);
           // accountPage.LaunchApp();
            //accountPage.BrowserMaximize();
            //accountPage.ImplicitWait();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"I am on the account page")]
        public void GivenIAmOnTheAccountPage()
        {
            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/account");
        }

        [When(@"I update my first name to ""(.*)""")]
        public void WhenIUpdateMyFirstNameTo(string firstName)
        {
            accountPage.EnterFirstName(firstName);
            accountPage.ClickSaveButton();
        }

        [When(@"I save the changes")]
        public void WhenISaveTheChanges()
        {
            accountPage.SaveChanges();
        }

        [When(@"I change my password from ""(.*)"" to ""(.*)""")]
        public void WhenIChangeMyPasswordFromTo(string oldPassword, string newPassword)
        {
            accountPage.EnterOldPassword(oldPassword);
            accountPage.EnterNewPassword(newPassword);
            accountPage.EnterConfirmPassword(newPassword);
            accountPage.ClickChangePasswordButton();
        }

        [Then(@"I message appeared as ""([^""]*)""")]
        public void ThenIMessageAppearedAs(string expectedMessage)
        {
            var actualMessage = accountPage.GetSuccessMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Then(@"I should see message ""(.*)""")]
        public void ThenIShouldseeMessage(string expectedMessage)
        {
            // Retrieve the actual success message from the AccountPage
            var actualMessage = accountPage.GetSuccessMessage();

            // Assert that the actual message matches the expected message
            Assert.AreEqual(expectedMessage, actualMessage);
        }

    }
}