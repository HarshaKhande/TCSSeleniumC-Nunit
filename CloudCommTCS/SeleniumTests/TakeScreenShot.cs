using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class TakeScreenShot
    {

        // driver instance at class level
        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {

            // configure the web driver manager to set up the chrome capabilities 
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // intialize the web driver 
            driver = new ChromeDriver();
        }

        [Test]
        public void testcase1()
        {

            driver.Navigate().GoToUrl("https://www.aboutamazon.in/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(6000);

            // Get full page height
            long height = (long)((IJavaScriptExecutor)driver)
                .ExecuteScript("return document.body.scrollHeight");

            // Resize browser window
            driver.Manage().Window.Size =
                new System.Drawing.Size(1920, (int)height);

            // take screen shot 

            // Take screenshot
            Screenshot screenshot =
                ((ITakesScreenshot)driver).GetScreenshot();

            screenshot.SaveAsFile("C:\\Users\\Harsha Patil\\tcstest.png");
           


        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }

    }
}
