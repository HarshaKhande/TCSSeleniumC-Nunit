using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class Login
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

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            driver.Manage().Window.Maximize();


            Thread.Sleep(8000);

            // enter  username 
            IWebElement username = driver.FindElement(By.XPath("//input[@name='username']"));
            username.SendKeys("Admin");

            Thread.Sleep(3000);

            // enter password

            IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys("admin123");

            Thread.Sleep(3000);

            // click on login button

            IWebElement loginbutton = driver.FindElement(By.CssSelector("button[type='submit']"));
            loginbutton.Click();

            Thread.Sleep(6000);

            // validation if the user is naviagted to home page

            IWebElement DashBoard = driver.FindElement(By.XPath("//h6[normalize-space()='Dashboard']"));

            if (DashBoard.Displayed)
            {

                Console.WriteLine("User is on the home page");
            }else
            {
                Console.WriteLine("User is not on the home page");

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
