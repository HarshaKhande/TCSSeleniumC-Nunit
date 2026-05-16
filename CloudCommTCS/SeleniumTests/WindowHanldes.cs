using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class WindowHanldes
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");

            Thread.Sleep(3000);

            driver.Manage().Window.Maximize();

            String parent = driver.CurrentWindowHandle;

            Console.WriteLine(parent);

            IWebElement ClickHere = driver.FindElement(By.LinkText("Click Here"));

            ClickHere.Click();

            WebDriverWait  wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(d => d.WindowHandles.Count == 2);

            var windowhandleseg = driver.WindowHandles;

          
            // Print all handles
            foreach (string window in windowhandleseg)
            {
                Console.WriteLine(window);
            }



            foreach (string win in driver.WindowHandles)
            {

                if (win!= parent)
                {
                    Console.WriteLine("In the child window");
                    driver.SwitchTo().Window(win);
                }
            }

            Assert.That(driver.Title, Is.EqualTo("New Window"));

            // close this child window
            driver.Close();

            driver.SwitchTo().Window(parent);

            Assert.That(driver.Title, Is.EqualTo("The Internet"));

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
