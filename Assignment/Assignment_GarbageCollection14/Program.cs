using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace EnterpriseLogSystem
{
    // ============================
    // TASK 1 – Short-Lived Object
    // ============================
    public class LogEntry
    {
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }

        public LogEntry(string message)
        {
            Message = message;
            CreatedAt = DateTime.Now;
        }
    }

    // ============================
    // TASK 2 – Medium-Lived Cache
    // ============================
    public class LogCache
    {
        private List<LogEntry> _cache = new List<LogEntry>();

        public void Add(LogEntry entry)
        {
            _cache.Add(entry);
        }

        public void Clear()
        {
            _cache.Clear();
        }
    }

    // ========================================
    // TASK 3 – Dispose + Finalize Pattern
    // ========================================
    public class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        private bool disposed = false;

        public FileLogger(string filePath)
        {
            _writer = new StreamWriter(filePath, true);
            Console.WriteLine("File resource acquired.");
        }

        public void WriteLog(string message)
        {
            _writer.WriteLine($"{DateTime.Now}: {message}");
        }

        // Deterministic cleanup
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("FileLogger disposed.");
        }

        // Core dispose logic
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                // Managed resources
                if (_writer != null)
                {
                    _writer.Close();
                    _writer.Dispose();
                    Console.WriteLine("Managed resources released.");
                }
            }

            // Unmanaged resources (if any)
            Console.WriteLine("Unmanaged resources released.");
            disposed = true;
        }

        // Finalizer – safety net
        ~FileLogger()
        {
            Dispose(false);
        }
    }

    // ========================================
    // TASK 4 – WeakReference + GC Demo
    // ========================================
    public class LogProcessor
    {
        private LogCache _cache;
        private WeakReference _weakCacheRef;

        public void ProcessLogs()
        {
            long initialMemory = GC.GetTotalMemory(false);
            Console.WriteLine($"Initial Memory: {initialMemory} bytes");

            _cache = new LogCache();
            _weakCacheRef = new WeakReference(_cache);

            // Create thousands of short-lived objects
            for (int i = 0; i < 10000; i++)
            {
                _cache.Add(new LogEntry($"Log {i}"));
            }

            long afterCreation = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory After Log Creation: {afterCreation} bytes");

            // Remove strong references
            _cache.Clear();
            _cache = null;

            // Force GC
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long afterGC = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory After GC: {afterGC} bytes");

            Console.WriteLine(
                $"Is Cache Alive (WeakReference): {_weakCacheRef.IsAlive}"
            );
        }
    }

    // ========================================
    // TASK 6 – Program Entry Point
    // ========================================
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Enterprise Log Processing System ===");

            // ---------------------------
            // Dispose Pattern Demo
            // ---------------------------
            using (FileLogger logger = new FileLogger("app.log"))
            {
                logger.WriteLog("Started");
            }

            // ---------------------------
            // WeakReference + GC Demo
            // ---------------------------
            LogProcessor processor = new LogProcessor();
            processor.ProcessLogs();

            // ---------------------------
            // TASK 5 – Generational GC
            // ---------------------------
            object obj = new object();
            Console.WriteLine($"Generation of new object: {GC.GetGeneration(obj)}");

            // Promote object to Gen 1 / Gen 2
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Console.WriteLine(
                $"Generation after GC: {GC.GetGeneration(obj)}"
            );

            Console.WriteLine("Application execution completed.");
        }
    }
}
