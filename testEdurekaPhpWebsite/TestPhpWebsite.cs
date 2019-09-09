using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testEdurekaPhpWebsite
{
    class TestPhpWebsite
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestPage()
        {
            driver.Url = "http://www.google.com";

        }

        [TearDown]
        public void Closebroswer ()
        {
            driver.Close();

        }

    }
}
