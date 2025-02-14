namespace ThreadApplication
{
    internal class Program
    {
        internal class StudentData
        {
            public void GetStudentDetails()
            {
                Console.WriteLine("Read Student Details");
            }

            public void DisplayStudentDetails()
            {
                Console.WriteLine("Write Student Details");
            }
        }
        public static void Method1()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for(int i=1; i<=5; i++)
            {
                Console.WriteLine("Method 1 - " + i);
            }
        }

        public static void Method2()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 2 - " + i);

                if (i == 3)
                {
                    Console.WriteLine("Database operation started.");
                    Thread.Sleep(5000);
                    Console.WriteLine("Database operation completed.");
                }
            }
        }

        public static void Method3()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 3 Reading - " + i);
            }
        }

        public static void Method4()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 4 Writing - " + i);
            }
        }

        public static void Method5()
        {
            lock (lockobj)
            {
                Console.WriteLine(lockobj);
                Console.Write("[Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("World of .NET");
            }
        }

        public static void Display(object x)
        {
            int v = (int)x;

            for(int i=0; i <= v ;i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " - " + i);
            }
        }

        static object lockobj = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Thread t1 = new Thread(Method5)
            {
                Name = "Thread1",
                Priority = ThreadPriority.Normal
            };

            Thread t2 = new Thread(Method5)
            {
                Name = "Thread2",
                Priority = ThreadPriority.Normal
            };

            Thread t3 = new Thread(Method5)
            {
                Name = "Thread2",
                Priority = ThreadPriority.Normal
            };

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main Thread Ended");


            //Thread t1 = new Thread(Display);
            //Thread t2 = new Thread(Display);
            //Thread t3 = new Thread(Display);

            //t1.Name = "Thread1";
            //t2.Name = "Thread2";
            //t3.Name = "Thread3";

            //t3.Priority = ThreadPriority.Highest;
            //t1.Priority = ThreadPriority.Lowest;

            //Console.WriteLine(t1.Priority);
            //Console.WriteLine(t2.Priority);
            //Console.WriteLine(t3.Priority);

            //t1.Start(10000);
            //t2.Start(10000);
            //t3.Start(10000);


            //ThreadStart ts = new ThreadStart(Method1);
            //Thread t1 = new Thread(ts);
            //t1.IsBackground = true;
            //Console.WriteLine(t1.IsBackground ? "t1 is Background Thread" : "t1 is a Foreground Thread");
            //t1.Start();

            //Thread t1 = new Thread(new ThreadStart(Method1));
            //Thread t2 = new Thread(delegate ()
            //{
            //    Console.WriteLine("Welcome To IVP");
            //});

            //Thread t3 = new Thread(() =>
            //{
            //    Console.WriteLine("Anonymous Function ... Arrow Syntax");
            //});



            ////Console.WriteLine("Main Thread Started");

            ////StudentData sd = new StudentData();

            ////ThreadStart del4 = new ThreadStart(sd.GetStudentDetails);

            ////del4 += new ThreadStart(sd.DisplayStudentDetails);

            ////ThreadStart del1 = new ThreadStart(Method1);
            ////ThreadStart del2 = new ThreadStart(Method2);
            ////ThreadStart del3 = new ThreadStart(Method3);

            ////del3 += new ThreadStart(Method4);

            ////Thread t1 = new Thread(del1);
            ////Thread t2 = new Thread(del2);
            ////Thread t3 = new Thread(del3);
            ////Thread t4 = new Thread(del4);

            ////t1.Name = "Thread 1";
            ////t2.Name = "Thread DB";
            ////t3.Name = "Thread File";
            ////t4.Name = "Student Thread";

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();
            ////t4.Start();

            //Console.WriteLine("Main Thread Ended");
            //Console.ReadKey();
        }
    }
}
