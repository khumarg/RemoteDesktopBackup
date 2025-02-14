using System.Diagnostics;

namespace Async_Parallel_ConsoleApp
{
    internal class Program
    {
        public static void Method1()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 1 completed by Thread = " + Thread.CurrentThread.ManagedThreadId);
        }

        public static void Method2()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 2 completed by Thread = " + Thread.CurrentThread.ManagedThreadId);
        }

        public static void Method3()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 3 completed by Thread = " + Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            ParallelProgrammingClass pp = new ParallelProgrammingClass();


            //ParallelOptions dop = new ParallelOptions()
            //{
            //    MaxDegreeOfParallelism = 2
            //};

            Console.WriteLine("Main Started");
            AsynchronousClass ac = new AsynchronousClass();
            ac.FetchInfo();
            Console.WriteLine("Main Ended");

            Console.ReadKey();

            //Console.WriteLine("Main Started");
            //AsynchronousClass.Test();
            //Console.WriteLine("Main Ended");
            //Console.ReadKey();

            //Stopwatch sw = new Stopwatch();
            //Console.WriteLine("Stopwatch started");
            //sw.Start();
            //Method1();
            //Method2();
            //Method3();

            //sw.Stop();
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);

            //sw.Restart();
            //Console.WriteLine("Stopwatch started");
            //sw.Start();

            //Parallel.Invoke (dop, Method1, Method2, Method3, () =>
            //{
            //    Console.WriteLine("Another function");
            //});

            //sw.Stop();
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);

            //pp.Test();
            //pp.TestParallel();

            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //Console.WriteLine("Stopwatch started");

            //for (int i = 0; i < 10; i++)
            //{ 
            //    Console.WriteLine(pp.DoSomeIndependentTask() + " - " + Thread.CurrentThread.ManagedThreadId);
            //}

            //Console.WriteLine("Stopwatch stopped");


            //sw.Stop();

            //Console.WriteLine("Time Taken: " + sw.ElapsedMilliseconds);

            //sw.Restart();

            //Console.WriteLine("Stopwatch started");

            //Parallel.For(1, 11, dop, num =>
            //{
            //    Console.WriteLine(pp.DoSomeIndependentTask() + " - " + Thread.CurrentThread.ManagedThreadId);
            //});

            //List<int> ls = Enumerable.Range(1, 10).ToList();

            //Parallel.ForEach(ls, dop, i =>
            //{
            //    long total = pp.DoSomeIndependentTask();
            //    Console.WriteLine("{0} - {1}", i, total);
            //});

            //Console.WriteLine("Stopwatch stopped");

            //sw.Stop();

            //Console.WriteLine("Time Taken: " + sw.ElapsedMilliseconds);
        }
    }
}
