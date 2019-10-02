using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Runtime.InteropServices;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized"); 
            options.AddArguments("disable-infobars"); 
            options.AddArguments("--disable-extensions"); 
            options.AddArguments("--disable-dev-shm-usage"); 
            options.AddArguments("--no-sandbox"); 
            options.AddArguments("--disable-setuid-sandbox");
            options.AddArguments("headless");
            string driverPath = "/usr/bin/";
            string driverExecutableFileName = "chromedriver";
            
            options.AddArguments("no-sandbox");
            options.BinaryLocation = "/usr/bin/google-chrome";
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(driverPath, driverExecutableFileName);
            IWebDriver driver = new ChromeDriver(service, options, TimeSpan.FromSeconds(200));
            driver.Url = "http://192.168.37.21/index.php";
            IWebElement AboutUsLink = driver.FindElement(By.LinkText("About Us"));
            AboutUsLink.Click();
            if (driver.PageSource.Contains("<b>about</b>"))
            {
                Assert.Pass();
            }
            else
                Assert.Fail();
            driver.Close();
            

        }

        [Test]
        public void Test1()
        {
            
        }
    }
}