using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver(); //(@"D:\ChromeDriver\chromedriver_win32\");
            driver.Url = "http://192.168.37.21/index.php";

            IWebElement AboutUsLink = driver.FindElement(By.LinkText("About Us"));
            AboutUsLink.Click();
            if (driver.PageSource.Contains("<b>about</b>"))
            {
                Assert.Pass();
                //   Console.WriteLine("About us page is working fine");
            }
            else
                Assert.Fail();
                //Console.WriteLine("There is a problem on about us page");
            driver.Close();
            

        }

        [Test]
        public void Test1()
        {
            
        }
    }
}