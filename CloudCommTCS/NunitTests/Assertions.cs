using Allure.NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NUnitAssertionsDemo
{

    [AllureNUnit]
    [TestFixture]
    public class AssertionExamples
    {
       
        
        /*
         * // 1. AreEqual
        [Test]
        public void AreEqualTest()
        {
            int expected = 100;
            int actual = 50 + 50;

            Assert.Equals(expected, actual);
        }

        // 2. AreNotEqual
        [Test]
        public void AreNotEqualTest()
        {
            Assert.NotEquals(100, 200);
        }

        // 3. IsTrue
        [Test]
        public void IsTrueTest()
        {
            Assert.IsTrue(10 > 5);
        }

        // 4. IsFalse
        [Test]
        public void IsFalseTest()
        {
            Assert.IsFalse(5 > 10);
        }

        // 5. IsNull
        [Test]
        public void IsNullTest()
        {
            string name = null;

            Assert.IsNull(name);
        }

        // 6. IsNotNull
        [Test]
        public void IsNotNullTest()
        {
            string name = "Harsha";

            Assert.IsNotNull(name);
        }

        // 7. String Contains
        [Test]
        public void ContainsTest()
        {
            string text = "Welcome to NUnit";

            Assert.That(text, Does.Contain("NUnit"));
        }

        // 8. Does Not Contain
        [Test]
        public void NotContainsTest()
        {
            string text = "Welcome to NUnit";

            Assert.That(text, Does.Not.Contain("Selenium"));
        }

        // 9. StartsWith
        [Test]
        public void StartsWithTest()
        {
            string text = "NUnit Framework";

            Assert.That(text, Does.StartWith("NUnit"));
        }

        // 10. EndsWith
        [Test]
        public void EndsWithTest()
        {
            string file = "Report.pdf";

            Assert.That(file, Does.EndWith(".pdf"));
        }

        // 11. Greater Than
        [Test]
        public void GreaterThanTest()
        {
            int number = 20;

            Assert.That(number, Is.GreaterThan(10));
        }

        // 12. Less Than
        [Test]
        public void LessThanTest()
        {
            int number = 5;

            Assert.That(number, Is.LessThan(10));
        }

        // 13. Empty Collection
        [Test]
        public void EmptyCollectionTest()
        {
            List<int> numbers = new List<int>();

            Assert.IsEmpty(numbers);
        }

        // 14. Collection Contains Item
        [Test]
        public void CollectionContainsTest()
        {
            List<string> names = new List<string>
            {
                "Harsha",
                "Ravi",
                "Kiran"
            };

            Assert.That(names, Does.Contain("Harsha"));
        }

        // 15. Exception Assertion
        [Test]
        public void ExceptionTest()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                int x = 10;
                int y = 0;
                int result = x / y;
            });
        }

        // 16. Multiple Assertions
        [Test]
        public void MultipleAssertionsTest()
        {
            string name = "Harsha";
            int age = 25;

            Assert.Multiple(() =>
            {
                Assert.That(name, Is.EqualTo("Harsha"));
                Assert.That(age, Is.GreaterThan(18));
            });
        }

        // 17. Pass Assertion
        [Test]
        public void PassTest()
        {
            Assert.Pass("Test passed successfully");
        }

        // 18. Fail Assertion
        [Test]
        public void FailTest()
        {
            Assert.Fail("Test failed intentionally");
        }

        // 19. Ignore Assertion
        [Test]
        public void IgnoreTest()
        {
            Assert.Ignore("Skipping this test");
        }

        // 20. Modern Assert.That Syntax
        [Test]
        public void ModernAssertionTest()
        {
            int result = 10;

            Assert.That(result, Is.EqualTo(10));
            Assert.That(result, Is.Not.EqualTo(5));
        } */
    }
}