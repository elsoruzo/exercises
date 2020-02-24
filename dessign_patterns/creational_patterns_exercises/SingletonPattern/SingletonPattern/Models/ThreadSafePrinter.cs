namespace TreadSafePrinter.Models
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public sealed class ThreadSafePrinter {  
        // TODO VOLATILE ?
    private static volatile ThreadSafePrinter _threadSafePrinterInstance;

    private Queue<string> _queue = new Queue<string>();
    private static string _instanceName;
    private static object _syncRoot = new object();
        // TODO SemaphoreSlim ?
        static SemaphoreSlim _sem = new SemaphoreSlim(1);
        private ThreadSafePrinter() { }
        public static ThreadSafePrinter GetPrinterInstance(string instanceName)
        {
            if (_threadSafePrinterInstance == null)
            {
                // TODO lock ?
                lock (_syncRoot)
                {
                //_sem.Wait();

                if (_threadSafePrinterInstance == null)
                    {
                        _instanceName = instanceName;
                        Console.WriteLine("{0} printer object created", instanceName);
                        _threadSafePrinterInstance = new ThreadSafePrinter();
                    }
                }
                //_sem.Release();
            }
            return _threadSafePrinterInstance;
        }

        internal void AddDocument(string documentName)
        {
            _queue.Enqueue(documentName);
        }

        internal void PrintDocument()
        {
            Console.WriteLine("Printing the content of the document: " +
                "\n {0}", _queue.Dequeue());
        }
    }  
}
