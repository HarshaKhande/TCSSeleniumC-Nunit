using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{



    [AllureNUnit]
    [TestFixtureSource(nameof(EnvironmentData))]
    public  class TestFixtureSourceEg
    {

        private string url;

        public TestFixtureSourceEg(string url)
        {
            this.url = url;
        }

        public static object[] EnvironmentData =
        {
            new object[] { "https://qa.example.com" },
            new object[] { "https://uat.example.com"}

        };

        [Test]

        public void checkurl()
        {

            if (url.Contains("example"))
            {

                Console.WriteLine("Url contains the example text");
            }
            else
            {

                Console.WriteLine("Url does not contains the example text");
            }
        }

    }
}
