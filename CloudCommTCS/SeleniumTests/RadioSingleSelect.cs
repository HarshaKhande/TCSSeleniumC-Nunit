using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;


namespace CloudCommTCS.SeleniumTests
{
    public  class RadioSingleSelect
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

            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/radio-button.php");


            driver.Manage().Window.Maximize();


            Thread.Sleep(8000);

            // single select radio button

            // click on radio button
            

            IWebElement radio2 = driver.FindElement(By.XPath("(//input[@type = 'radio'])[2]"));

            if (radio2.Enabled)
            {
                radio2.Click();
            }

            IWebElement radio1 = driver.FindElement(By.XPath("(//input[@type = 'radio'])[1]"));

            if (radio1.Displayed)
            {

                radio1.Click();
            }
        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }


    }
}

