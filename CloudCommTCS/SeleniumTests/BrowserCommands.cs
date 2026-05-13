using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V145.PWA;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    internal class BrowserCommands
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


            // Launch  browser
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");

            // set the window width size

            driver.Manage().Window.Maximize();

            // driver.Manage().Window.Minimize();

            // get the title of the page 

            String title = driver.Title;

            Console.WriteLine(title);

            // get the current url 

            String url = driver.Url;

            Console.WriteLine(url);

            // fetch the page source - html code

            String pagesrc = driver.PageSource;

            Console.WriteLine(pagesrc);

        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }

    }
}
