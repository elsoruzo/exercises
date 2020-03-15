namespace TreadSafePrinter.Models
{
    using System;
    using System.Collections.Concurrent;

    public sealed class ThreadSafePrinter {

    private static ThreadSafePrinter _threadSafePrinterInstance;

    private ConcurrentQueue<string> _queue = new ConcurrentQueue<string>();
   
    private static object _syncRoot = new object();
        private ThreadSafePrinter() { }
        public static ThreadSafePrinter GetInstance(string instanceName)
        {
            if (_threadSafePrinterInstance == null)
            {
                lock (_syncRoot)
                {

                if (_threadSafePrinterInstance == null)
                    {
                        Console.WriteLine($"{ instanceName} printer object created");
                        _threadSafePrinterInstance = new ThreadSafePrinter();
                    }
                }
            }
            return _threadSafePrinterInstance;
        }

        internal void AddDocument(string documentName)
        {
            _queue.Enqueue(documentName);
        }

        internal void PrintDocument()
        {
            var result = string.Empty;
           _queue.TryDequeue(out result);
            Console.WriteLine("Printing the content of the document: " +
                "\n {0}", result);
        }
    }  
}
