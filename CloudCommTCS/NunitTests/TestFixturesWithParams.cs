using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{



    [AllureNUnit]
    [TestFixture("admin", "admin123", true)]
    [TestFixture("user", "user123", true)]
    [TestFixture("guest", "pass", false)]
    public  class TestFixturesWithParams
    {

        private string username;
        private string password;
        private bool expectedResult;

        public TestFixturesWithParams(string username, string password, bool expectedResult)
        {

          this.username = username;
          this.password = password;
          this.expectedResult = expectedResult;
            
        }


        [Test]
         public void validatelogin()
        {
            bool actualResult = (username == "admin" && password == "admin123") ||
                            (username == "user" && password == "user123");

            if (expectedResult == actualResult)
            {

                Console.WriteLine("Both are same");
            }else
            {

                Console.WriteLine("Both are not same");
            }


        }



    }
}
