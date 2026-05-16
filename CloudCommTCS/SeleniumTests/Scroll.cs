using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;
using static System.Net.Mime.MediaTypeNames;

namespace CloudCommTCS.SeleniumTests
{
    public class Scroll
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

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            Thread.Sleep(3000);

            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            IWebElement Aboutamazon = driver.FindElement(By.XPath("//a[normalize-space()='About Amazon']"));

         //   Thread.Sleep(6000);

            // Scroll element in actions class 

          new Actions(driver).ScrollToElement(Aboutamazon);

        //    Aboutamazon.Click();


         //   Thread.Sleep(3000);

            
        //IWebElement Aboutamazonlogo = driver.FindElement(By.XPath("//div[@data-testid='icon-AmazonLogo']//*[name()='svg']//*[name()='g' and contains(@clip-path,'url(#clip0')]//*[name()='path' and contains(@d,'M4.84063 1')]"));

         //   Assert.That(Aboutamazonlogo.Displayed, Is.True);

            Thread.Sleep(6000);

            // scrool with x and y cooridnates 

            // java script executor scroll

            // vertical scroll

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // x coordinates 
            // y cooridnates 

            // down scroll

            js.ExecuteScript("window.scrollBy(0, 1000)", "");

            // up scroll

            Thread.Sleep(4000);


            js.ExecuteScript("window.scrollBy(0, -500)", "");


            // horizontal scroll 

            driver.Manage().Window.Minimize();

            // right  scroll

            js.ExecuteScript("window.scrollBy(700, 0)", "");

            // left  scroll

            Thread.Sleep(4000);


            js.ExecuteScript("window.scrollBy(-300,0)", "");


        }

        [TearDown]
        public void closebrowser()
        {

            // it will close the current browser session
            driver.Close();

        }
    }
}
