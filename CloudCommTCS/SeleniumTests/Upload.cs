using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class Upload
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

            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/upload-download.php");

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            IWebElement upload = driver.FindElement(By.Id("uploadFile"));

            upload.SendKeys("C:\\Users\\Harsha Patil\\Documents\\co.JPG");

            Thread.Sleep(3000);

            string text = upload.Text;

           // Console.WriteLine(text);

            //Assert.That(upload, Does.Contain("co"));

            Thread.Sleep(3000);




        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }

    }
}
