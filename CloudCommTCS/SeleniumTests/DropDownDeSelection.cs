using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class DropDownDeSelection
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

            driver.Navigate().GoToUrl("https://www.testmuai.com/selenium-playground/select-dropdown-demo/?utm_source=chatgpt.com");

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            IWebElement dropdown = driver.FindElement(By.Id("multi-select"));

            // Assert.IsNotNull(dropdown);

            var select = new SelectElement(dropdown);

            // select by visible text

            Thread.Sleep(2000);

     

            select.SelectByText("California");

            // select by index  florida

            Thread.Sleep(2000);

            select.SelectByIndex(2);

            // select by value 

            Thread.Sleep(4000);

            select.SelectByValue("Florida");

            Thread.Sleep(2000);

            // deselect by text 

            select.DeselectByText("California");

            Thread.Sleep(2000);


            // deselect by index

            select.DeselectByIndex(2);

            // deselct by value 

            select.DeselectByValue("Florida");

            // deselect all 

            // select by value 

            Thread.Sleep(2000);

            select.SelectByValue("New York");

            Thread.Sleep(2000);


            select.SelectByValue("Ohio");

            Thread.Sleep(2000);


            select.DeselectAll();






        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }


    }
}
