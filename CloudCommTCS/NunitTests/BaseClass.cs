using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{

    [AllureNUnit]
    public class BaseClass
    {
        [OneTimeSetUp]
        public void opendbconn()
        {

            TestContext.Progress.WriteLine("Open db connection");
        }


        [OneTimeTearDown]
        public void closedbconn()
        {

            TestContext.Progress.WriteLine("Close  the db connection");
        }

        [SetUp]
        public void launchbrowser()
        {

            Console.WriteLine("Launch browser");
        }


        [TearDown]
        public void closebrowser()
        {

            Console.WriteLine("Close  browser");
        }

      





    }
}
