using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public class FindLinksCountAndText
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            // get all the links using anchor tag

            IReadOnlyList<IWebElement> links = driver.FindElements(By.TagName("a"));

            // get the count of the links 

            Console.WriteLine(links.Count);

            // Print the text and URL
            
            foreach(IWebElement link in links)
            {
                string linktext = link.Text;
                string href = link.GetAttribute("href");

                Console.WriteLine("Link Text : " + linktext);
                Console.WriteLine("URL       : " + href);

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
