using AT_Assignment_Project_GaneshNidhonkar.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_GaneshNidhonkar.Pages
{
    public class SearchPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //Creating Constructor
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}

