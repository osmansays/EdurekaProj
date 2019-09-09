using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testEdurekaPhpWebsite
{
    class Program
    {
       // public static IWebDriver driver;

        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"D:\ChromeDriver\chromedriver_win32\");
            driver.Url = "http://192.168.36.200:8000/index.php";

            
            IWebElement AboutUsLink= driver.FindElement(By.LinkText("About Us"));
            AboutUsLink.Click();
              if (driver.PageSource.Contains("<b>about</b>"))
                Console.WriteLine("About us page is working fine");
            else
                Console.WriteLine("There is a problem on about us page");
            driver.Close();
        }
   

    }
}
