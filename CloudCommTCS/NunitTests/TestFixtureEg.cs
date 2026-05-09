using Allure.NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{


    [AllureNUnit]
    [TestFixture]
    internal class TestFixtureEg
    {

        [Test]
        public void add_test()
        {

            int result = 2 + 4;
            int expected = 6;
           // Assert.AreEqual(result,expected );
        }


    }
}
