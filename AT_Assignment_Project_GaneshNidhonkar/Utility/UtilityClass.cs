using AT_Assignment_Project_GaneshNidhonkar.Config;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_GaneshNidhonkar.Utility
{
    public class UtilityClass : ConfigClass
    {
        public void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "CHROME":
                driver = new ChromeDriver(chromeDriverPath);
                    break;

                case "EDGE":
                    driver = new EdgeDriver(edgeDriverPath);
                    break;

                default: throw new ArgumentException("Error");

            }
        }

        public void LaunchApp()
        {
            driver.Url = url;

        }
        public void CloseBrowser()
        {
            driver.Quit();
        }
        public void BrowserMaximize()
        {
            driver.Manage().Window.Maximize();
        }
        public void pageLoad() 
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTime);
        }
        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTime);
        }
        public string PageTitle()
        {
            return driver.Title;
        }
    }
}
