using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
   public  class Download
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

            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/upload-download.php");

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

           IWebElement download   = driver.FindElement(By.Id("downloadButton"));

            download.Click();

            string downloadDir = "C:\\Users\\Harsha Patil\\Downloads";

            var files = Directory.GetFiles(downloadDir);

            if (files.Length > 0)
            {

                Console.WriteLine("File downloaded" + Path.GetFileName(files[0]));
            }
            else
            {

                Console.WriteLine("Down load failed");
            }





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
