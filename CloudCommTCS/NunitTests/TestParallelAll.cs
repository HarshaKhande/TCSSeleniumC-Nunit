using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;


[assembly: LevelOfParallelism(4)]
namespace CloudCommTCS.NunitTests
{

    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    public  class Logintests
    {
        [Test]
        public void Login1()
        {
            Console.WriteLine("Login1 Started");
            Console.WriteLine($"Start Test1: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test1 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test1: {DateTime.Now:HH:mm:ss}");

        }

        [Test]
        public void Login2()
        {
            Console.WriteLine("Login2 Started");
            Console.WriteLine($"Start Test2: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test2 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test2: {DateTime.Now:HH:mm:ss}");

        }



    } // end of first class


    // 2 nd class
    [Parallelizable(ParallelScope.All)]
    public class Paymenttests
    {
        [Test]
        public void Payment1()
        {
            Console.WriteLine("Payment1 Started");
            Console.WriteLine($"Start Test3: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test3 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test3: {DateTime.Now:HH:mm:ss}");

        }

        [Test]
        public void Payment2()
        {
            Console.WriteLine("Payment2 Started");
            Console.WriteLine($"Start Test4: {DateTime.Now:HH:mm:ss}");
            Console.WriteLine($"Test4 Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"End Test4: {DateTime.Now:HH:mm:ss}");

        }

    }
}
