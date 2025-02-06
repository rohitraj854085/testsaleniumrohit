using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager.DriverConfigs.Impl;


namespace selenium_tests
{
    public class Selenium_Test1
    {
        IWebDriver driver;
        [SetUp]
        public void OpenBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            //driver = new EdgeDriver();
            
            driver.Manage().Window.Maximize();
         
        }

        [Test]
        public void Test1()
        {
            driver.Url ="https://www.selenium.dev/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            
        }

        [Test]
        public void Test2()
        {
            driver.Url ="https://www.zomato.com/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
        }

        [TearDown]
        public void Close()
        {
            TestContext.Progress.WriteLine("This is a TearDown");
            driver.Close();
        }
    }
}