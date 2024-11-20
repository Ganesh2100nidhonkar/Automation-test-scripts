using AT_Assignment_Project_GaneshNidhonkar.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace AT_Assignment_Project_GaneshNidhonkar.Steps
{
    [Binding]
    public class SearchPageSteps
    {
        private IWebDriver driver;
        private HomePage homePage;
        private SearchPage searchPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            searchPage = new SearchPage(driver);
            homePage.LaunchApp();
            homePage.BrowserMaximize();
            homePage.ImplicitWait();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"I am on the search page")]
        public void GivenIAmOnTheSearchPage()
        {
            homePage.EnterSearch("Product");
            homePage.Clicksearchbutton();
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

        [Then(@"I should see a message ""(.*)""")]
        public void ThenIShouldSeeAMessage(string message)
        {
            // Implement message validation
        }
    }
}
