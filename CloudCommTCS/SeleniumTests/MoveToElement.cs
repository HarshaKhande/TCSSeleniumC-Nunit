using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests.ActionsAPI
{
    public  class MoveToElement
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

            Thread.Sleep(3000);

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            IWebElement Prime = driver.FindElement(By.LinkText("Prime"));

            Assert.That(Prime.Displayed, Is.True);

            new Actions(driver).MoveToElement(Prime).Perform();

            Thread.Sleep(3000);

            IWebElement ToolTip = driver.FindElement(By.XPath("//span[contains(text(),'Shopping plans starting at ₹399/year')]"));

            Assert.That(ToolTip.Displayed, Is.True);

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
