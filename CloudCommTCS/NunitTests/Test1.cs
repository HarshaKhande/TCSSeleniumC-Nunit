using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{


    [AllureNUnit]
    internal class Test1 : BaseClass
    {
        [Test]
        public void Testcase1()
        {

            Console.WriteLine("This is the first Nunit testcase");
        }

        [Test]
        public void Testcase2()
        {

            Console.WriteLine("This is the second Nunit testcase");
        }

        [Test]
        public void Testcase3()
        {

            Console.WriteLine("This is the third  Nunit testcase");
        }




    }
}
