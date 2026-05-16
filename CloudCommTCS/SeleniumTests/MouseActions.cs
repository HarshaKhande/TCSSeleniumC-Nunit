using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace CloudCommTCS.SeleniumTests.ActionsAPI
{
    public  class MouseActions
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

            Thread.Sleep(5000);

            // Double click

            IWebElement Bestsellers = driver.FindElement(By.LinkText("Bestsellers"));

            // Actions class initialization to be done to use the features

            new Actions(driver).DoubleClick(Bestsellers).Perform();

            Thread.Sleep(3000);

            driver.Navigate().Back();

            Thread.Sleep(3000);


            // Context click - right click 

            IWebElement Sell = driver.FindElement(By.LinkText("Sell"));

            // Actions class initialization to be done to use the features

            new Actions(driver).ContextClick(Sell).Perform();

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
