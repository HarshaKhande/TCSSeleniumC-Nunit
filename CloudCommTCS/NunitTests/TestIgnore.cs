using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{


    [AllureNUnit]
    [TestFixture]
    internal class TestIgnore : BaseClass
    {

        [Test, Order(1)]
        [Ignore("Waiting for Joe to fix his bug")]
        public void login()
        {

            Console.WriteLine("Logging in the application");
        }


        [Test, Order(2)]
        public void productsdisplay()
        {

            Console.WriteLine("Products display");
        }

        [Test, Order(3)]
       
        public void addtocart()
        {

            Console.WriteLine("Item added to cart");
        }


        [Test, Order(4)]
        public void logout()
        {

            Console.WriteLine("Logged out of the application");
        }

    }
}
