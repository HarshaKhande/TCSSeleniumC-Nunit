using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V145.Storage;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests.ActionsAPI
{
    public  class Keyboard
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

            driver.Navigate().GoToUrl("https://www.facebook.com/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(6000);

            new Actions(driver).KeyDown(Keys.Shift).SendKeys("hello").Perform();

            Thread.Sleep(1000);

            // cntrl a

            new Actions(driver).KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();


            // cntrl c 

            new Actions(driver).KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();

            // cntl v


            IWebElement pass = driver.FindElement(By.XPath("//input[@id='_R_66mkqsqppb6amH1_']"));

            Thread.Sleep(3000);

            new Actions(driver).MoveToElement(pass).KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();

        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }
    }
}
