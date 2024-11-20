using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_GaneshNidhonkar.Config
{
    public class ConfigClass
    {


        public IWebDriver driver = new EdgeDriver();
        public string chromeDriverPath = @".\Drivers\chromedriver.exe";
        public string edgeDriverPath = @"C:\Users\ganesh.nidhonkar\source\repos\AT_Assignment_Sol_GaneshNidhonkar\AT_Assignment_Project_GaneshNidhonkar\Drivers\msedgedriver.exe";
        public string url = "https://demo.nopcommerce.com/";

   

        public int pageLoadTime = 10;
        public int implicitWaitTime = 10;
    }
}
