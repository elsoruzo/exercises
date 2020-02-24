namespace SingletonPattern
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using TreadSafePrinter.Models;
    class Program
    {
        static void Main(string[] args)
        {
            InitializeThreadSafePrinterObject();
        }

        static void InitializeThreadSafePrinterObject()
        {
            ThreadSafePrinter firstPrinterObject = null;
            ThreadSafePrinter secondPrinterObject = null;
            ThreadSafePrinter thirdPrinterObject = null;

           // Task vs Thrad ??

            Task task1 = Task.Factory.StartNew(() =>
            {
                firstPrinterObject = GetThreadSafePrinterInstance("First", "First-Document");
            });
            Task task2 = Task.Factory.StartNew(() =>
            {
                secondPrinterObject = GetThreadSafePrinterInstance("Second", "Second-Document");
            });
            Task task3 = Task.Factory.StartNew(() =>
            {
                thirdPrinterObject = GetThreadSafePrinterInstance("Third", "Third-Document");
            });
            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("All threads complete");
            Console.WriteLine("Are these First Printer Object And Second Printer Object Same - {0} ", firstPrinterObject.Equals(secondPrinterObject) ? "Yes" : "No");
            Console.WriteLine("Are these First Printer Object And Third Printer Object Same - {0} ", firstPrinterObject.Equals(thirdPrinterObject) ? "Yes" : "No");
            Console.WriteLine("Are these Second Printer Object And Third Printer Object Same - {0} ", secondPrinterObject.Equals(thirdPrinterObject) ? "Yes" : "No");

            Thread process1 = new Thread(() =>
            {
                TestSingleton("process1");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("process2");
            });

            Thread process3 = new Thread(() =>
            {
                TestSingleton("process3");
            });

            process1.Start();
            process1.Join();

            process2.Start();
            process3.Start();
            process3.Join();
            process2.Join();

            Console.ReadLine();
        }
        private static ThreadSafePrinter GetThreadSafePrinterInstance(string instanceName, string documentName)
        {
            var printerObject = ThreadSafePrinter.GetPrinterInstance(instanceName);
            printerObject.AddDocument(documentName);
            printerObject.PrintDocument();
            return printerObject;
        }
        public static void TestSingleton(string value)
        {
            ThreadSafePrinter singleton = ThreadSafePrinter.GetPrinterInstance(value);
            singleton.AddDocument(value);
            singleton.PrintDocument();
        }
    }
}
