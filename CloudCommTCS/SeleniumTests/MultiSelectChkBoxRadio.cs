using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
   public  class MultiSelectChkBoxRadio
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


            Thread.Sleep(8000);

        
            // fetch the list of web elements  check boxes 

            IReadOnlyList<IWebElement> checkboxes = driver.FindElements(By.XPath("//input[@type = 'checkbox']"));

            foreach(IWebElement e in checkboxes)
            {

            Console.WriteLine(e.Text);

                Thread.Sleep(2000);

                // click on the element 

                e.Click();


            }


            // click on radio  buttons


            IReadOnlyList<IWebElement> radios = driver.FindElements(By.XPath("//input[@type = 'radio']"));

            foreach (IWebElement v in radios)
            {

                Console.WriteLine(v.Text);

                Thread.Sleep(2000);

                // click on the element 

                v.Click();


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

