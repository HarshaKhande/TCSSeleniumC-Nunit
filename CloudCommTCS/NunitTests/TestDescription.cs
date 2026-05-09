using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{


    [AllureNUnit]
    internal class TestDescription : BaseClass
    {

        [Test, Order(1) , Category("Regression")]
        [Description ("This testcases verifies the login to the application")]
        public void login()
        {

            Console.WriteLine("Logging in the application");
        }


        [Test, Order(2)]
        [Description("This testcases verifies the products display in the products page")]
        public void productsdisplay()
        {

            Console.WriteLine("Products display");
        }

        [Test,Order(3)]
        [Category("Regression")]
        [Category("Sanity")]
        [Description("This testcases verifies the add to cart functionality")]
        public void addtocart()
        {

            Console.WriteLine("Item added to cart");
        }


        [Test, Order(4)]
        [Description("This testcases verifies the loogging out of application")]
        public void logout()
        {

            Console.WriteLine("Logged out of the application");
        }


        [Test]
        public void payment()
        {

            Console.WriteLine("Payment done");
        }

    }
}
