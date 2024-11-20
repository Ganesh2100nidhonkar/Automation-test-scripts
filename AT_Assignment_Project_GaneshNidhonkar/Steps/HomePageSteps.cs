using AT_Assignment_Project_GaneshNidhonkar.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AT_Assignment_Project_GaneshNidhonkar.Utility;

namespace AT_Assignment_Project_GaneshNidhonkar.Steps
{
    [Binding]
    public class HomePageSteps : UtilityClass
    {
        private IWebDriver driver;
        private HomePage homePage;
        private LoginPage loginPage;
        private RegisterPage registerPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            registerPage = new RegisterPage(driver);
            homePage.LaunchApp();
            homePage.BrowserMaximize();
            homePage.ImplicitWait();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            homePage.LaunchApp();
        }

        [When(@"I click on the login link")]
        public void WhenIClickOnTheLoginLink()
        {
            driver.FindElement(By.LinkText("Log in")).Click();
        }

        [When(@"I click on the register link")]
        public void WhenIClickOnTheRegisterLink()
        {
            driver.FindElement(By.LinkText("Register")).Click();
        }

        [When(@"I enter ""(.*)"" in the search bar")]
        public void WhenIEnterInTheSearchBar(string searchValue)
        {
            homePage.EnterSearch(searchValue);
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            homePage.Clicksearchbutton();
        }

        [Then(@"I should see search results for ""(.*)""")]
        public void ThenIShouldSeeSearchResultsFor(string searchValue)
        {
            // Implement search result validation
        }

        [When(@"I click the log out link")]
        public void WhenIClickTheLogOutLink()
        {
            driver.FindElement(By.LinkText("Log out")).Click();
        }

        [Then(@"I should be navigated to the home page")]
        public void ThenIShouldBeNavigatedToTheHomePage()
        {
            Assert.AreEqual("nopCommerce demo store", driver.Title);
        }

        [Then(@"I should be navigated to the register page")]
        public void ThenIShouldBeNavigatedToTheRegisterPage()
        {
            Assert.AreEqual("Register", driver.Title);
        }
    }
}