using AT_Assignment_Project_GaneshNidhonkar.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace AT_Assignment_Project_GaneshNidhonkar.Steps
{
    [Binding]
    public class LoginPageSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            loginPage.LaunchApp();
            loginPage.BrowserMaximize();
            loginPage.ImplicitWait();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/login");
        }

        [When(@"I enter the email ""(.*)""")]
        public void WhenIEnterTheEmail(string email)
        {
            loginPage.EnterEmail(email);
        }

        [When(@"I enter the password ""(.*)""")]
        public void WhenIEnterThePassword(string password)
        {
            loginPage.EnterPassword(password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should be navigated to the account page")]
        public void ThenIShouldBeNavigatedToTheAccountPage()
        {
            Assert.AreEqual("My account", driver.Title);
        }

        [Then(@"I should see an error message indicating invalid credentials")]
        public void ThenIShouldSeeAnErrorMessageIndicatingInvalidCredentials()
        {
            var errorMessage = driver.FindElement(By.ClassName("message-error")).Text;
            Assert.AreEqual("Login was unsuccessful. Please correct the errors and try again.", errorMessage);
        }
    }
}