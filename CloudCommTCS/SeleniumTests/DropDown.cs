using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class DropDown
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

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            IWebElement dropdown = driver.FindElement(By.Id("dropdown-class-example"));

            // Assert.IsNotNull(dropdown);

            var select = new SelectElement(dropdown);

            // select by visible text - Option2

            Thread.Sleep(2000);

            select.SelectByText("Option2");

            // select by index - option1

            Thread.Sleep(2000);

            select.SelectByIndex(1);

            // select by value  - option3

            Thread.Sleep(4000);

            select.SelectByValue("option3");

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

