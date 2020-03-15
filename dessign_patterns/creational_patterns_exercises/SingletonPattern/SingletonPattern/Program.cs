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

        public static void TestSingleton(string value)
        {
            ThreadSafePrinter singleton = ThreadSafePrinter.GetInstance(value);
            singleton.AddDocument(value);
            singleton.PrintDocument();
        }
    }
}
