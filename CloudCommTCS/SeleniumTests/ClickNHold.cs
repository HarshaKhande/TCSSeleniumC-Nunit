using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests.ActionsAPI
{
    public  class ClickNHold
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

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();


            Thread.Sleep(6000);

            IWebElement Prime = driver.FindElement(By.LinkText("Prime"));

            Assert.That(Prime.Displayed, Is.True);

            // click and hold and release 

            new Actions(driver).ClickAndHold(Prime)
                .Pause(TimeSpan.FromSeconds(5))
                .Release()
                .Perform();










        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }
    }
}
