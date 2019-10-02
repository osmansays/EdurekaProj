using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            ChromeOptions options = new ChromeOptions();
            //System.setProperty("webdriver.chrome.driver", "/usr/bin/chromedriver");
            options.AddArguments("start-maximized"); // open Browser in maximized mode
            options.AddArguments("disable-infobars"); // disabling infobars
            options.AddArguments("--disable-extensions"); // disabling extensions
            //options.AddArguments("--disable-gpu"); // applicable to windows os only
            options.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
            options.AddArguments("--no-sandbox"); // Bypass OS security model
            //IWebDriver driver=new ChromeDriver();
            //  if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            IWebDriver driver = new ChromeDriver(@"/usr/bin/chromedriver",options); //(@"D:\ChromeDriver\chromedriver_win32\");

         //   if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
          //      driver = new ChromeDriver(@"chromedriver");

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