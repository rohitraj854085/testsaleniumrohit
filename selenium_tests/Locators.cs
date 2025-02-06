using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using Test1;


namespace selenium_tests
{
    public class Locators
    {
        //XPaths...

        IWebDriver driver;
        [SetUp]
        public void OpenBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();
            driver.Url = "https://practicetestautomation.com/practice-test-login/";
        }
        [Test]
        public void LocatorsIdentification()
        {
            driver.FindElement(By.Id("username")).SendKeys("student");
            driver.FindElement(By.Id("password")).SendKeys("Password123");
            driver.FindElement(By.Id("submit")).Click();
            if(driver.Url.Contains("practicetestautomation.com/logged-in-successfully/"))
            {
                TestContext.Progress.WriteLine("Logged in successfully");
            }
            driver.Close();
        }

    }
}

