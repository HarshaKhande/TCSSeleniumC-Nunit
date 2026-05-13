using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CloudCommTCS.SeleniumTests
{
    public  class ReadText
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

            // Implicit wait at the session level 

            // applied at the global level and it is applicable to all the elements in the script

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            IWebElement HeaderText = driver.FindElement(By.XPath("//h1[normalize-space()='Dropdown Demo']"));

            // explict wait - wait for the element explicitly 

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => HeaderText.Displayed);

            // custom waits 

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
            {
                PollingInterval = TimeSpan.FromMilliseconds(300),
            };
            wait1.IgnoreExceptionTypes(typeof(ElementNotInteractableException));

            wait1.Until(d => {
                HeaderText.SendKeys("Displayed");
                return true;
            });

            String actualText = HeaderText.Text;

            Console.WriteLine(actualText);

            String Expectedtext = "Dropdown Demo";

            Console.WriteLine(Expectedtext);

            //  Assert.AreEqual(actualText, Expectedtext);      

        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }

    }
}
