using Allure.NUnit;
using CloudCommTCS.NunitTests;
using System;
using System.Collections.Generic;
using System.Text;



namespace CloudCommTCS.Parallel
{


    [AllureNUnit]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Logintests123: BaseClass
    {
        [Test]
        public void Login12()
        {
            Console.WriteLine("Login1 Started");
            Console.WriteLine($"Start Test1: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test1 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test1: {DateTime.Now:HH:mm:ss}");

        }

        [Test]
        public void Login13()
        {
            Console.WriteLine("Login2 Started");
            Console.WriteLine($"Start Test2: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test2 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test2: {DateTime.Now:HH:mm:ss}");

        }



    } // end of first class


    // 2 nd class
    [Parallelizable(ParallelScope.Fixtures)]
    public class Paymenttests123:BaseClass
    {
        [Test]
        public void Payment12()
        {
            Console.WriteLine("Payment1 Started");
            Console.WriteLine($"Start Test3: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test3 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test3: {DateTime.Now:HH:mm:ss}");

        }

        [Test]
        public void Payment13()
        {
            Console.WriteLine("Payment2 Started");
            Console.WriteLine($"Start Test4: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test4 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test4: {DateTime.Now:HH:mm:ss}");

        }

    }

}