using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class Frames
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

            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            // Frame switching for frames name , class , id - xpath 

          //  IWebElement Frame = driver.FindElement(By.XPath("//iframe[@class= 'demo-frame']"));

            driver.SwitchTo().Frame(0);

            IWebElement radioNewyork = driver.FindElement(By.XPath("//label[normalize-space()='New York']"));

            radioNewyork.Click();

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
