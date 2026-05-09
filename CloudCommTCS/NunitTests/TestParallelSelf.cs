using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommTCS.NunitTests
{
    [AllureNUnit]
    internal class TestParallelSelf
    {

        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void testcase1()
        {

            Console.WriteLine($"Start Test1: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test1 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test1: {DateTime.Now:HH:mm:ss}");


        }



        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void testcase2()
        {


            Console.WriteLine($"Start Test2: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test2 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test2: {DateTime.Now:HH:mm:ss}");
          

        }

        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void testcase3()
        {


            Console.WriteLine($"Start Test3: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test3 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test3: {DateTime.Now:HH:mm:ss}");


        }



    }
}
