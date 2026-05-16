using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests.ActionsAPI
{
    public  class DragDrop
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

            driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");

            Thread.Sleep(3000);

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            driver.SwitchTo().Frame(0);

            // Source Element 

            IWebElement sourceFrom = driver.FindElement(By.Id("draggable"));

            Assert.That(sourceFrom.Displayed, Is.True); 

            // Destination element 

            IWebElement destTO = driver.FindElement(By.Id("droppable"));

            Assert.That(destTO.Displayed, Is.True);

            // Actions class initilaization

            new Actions(driver).DragAndDrop(sourceFrom, destTO).Perform();

            Thread.Sleep(2000);

        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }
    }
}
