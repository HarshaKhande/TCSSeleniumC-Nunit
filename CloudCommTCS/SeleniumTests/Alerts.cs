using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class Alerts
    {
        // driver instance at class level
        IWebDriver driver;

        [SetUp]

        public void startbrowser()
        {

            // configure the web driver manager to set up the chrome capabilities 
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // intialize the web driver 
            driver = new FirefoxDriver();
        }
        [Test]
        public void testcase1()
        {

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            IWebElement InfoAlert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));

            // Informtaiomla alert 


            InfoAlert.Click();

            //Wait for the alert to be displayed and store it in a variable

            //IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());

            // switch the control to the alert 

            IAlert alt = driver.SwitchTo().Alert();

            // click on OK button 

            alt.Accept();




        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }
    }

}
}
