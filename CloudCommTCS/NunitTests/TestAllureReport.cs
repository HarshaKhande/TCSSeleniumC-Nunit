using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{

    [AllureNUnit]
    internal class TestAllureReport
    {

        [Test]
        public void login()
        {

            Console.WriteLine("Login");

        }


        [Test]
        public void productsdisplay()
        {


            Console.WriteLine("Products display");

        }

        [Test]
        public void addtocart()
        {

            Console.WriteLine("Item added to cart");

        }


        [Test]
        public void logout()
        {

            Console.WriteLine("Logged out of the application");

        }
    }
}
