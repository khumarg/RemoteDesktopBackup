using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class LoopsAndConstructs
    {
        public void numbersExcept3and6()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3 || i == 6) continue;
                Console.WriteLine(i);
            }
        }
        public void ConstructIfElse()
        {
            int a = 10, b = 20;

            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
        }

        public void ConstructElseIf()
        {
            int a = 10, b = 10, c = 5;
            if (a >= b && a > c)
            {
                Console.WriteLine("a is the greatest");
            }
            else if (b > a && b >= c)
            {
                Console.WriteLine("b is the greatest");
            }
            else
            {
                Console.WriteLine("c is the greatest");
            }
        }

        public void ConstructSwitchCase()
        {
            char data;
            data = char.Parse(Console.ReadLine());

            switch (data)
            {
                case '1':
                    Console.WriteLine("Saving"); break;
                case '2': Console.WriteLine("Current"); break;
                case '3': Console.WriteLine("Joint"); break;

                default: Console.WriteLine("Invalid Option"); break;
            }
        }

        public void WhileDemo()
        {
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine(i++);
            }
        }

        public void DoWhileDemo()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i++);
            } while(i<=10);
        }

        public void ForDemo()
        {
            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void evenNumbers()
        {
            Console.WriteLine("Even Numbers");
            for (int j = 0; j<=10; j+=2)
            {
                Console.WriteLine(j);
            }

            int i = 0;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i += 2;
            }

            i = 0;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 10);
        }

        public void oddNumbers()
        {
            Console.WriteLine("Odd Numbers");
            for(int j = 1;j<=10;j+=2)
            {
                Console.WriteLine(j);
            }

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i += 2;
            }

            i = 1;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 10);

        }

        public void table(int n)
        {
            for(int i=1; i<=10;i++)
            {
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
        }

        public void fibbonacci(int n)
        {
            int a = 0, b = 1;
            int c = a + b;

            Console.Write(a + ", ");
            Console.Write(b + ", ");

            for(int i=1; i<=n; i++)
            {
                Console.Write(c + ", ");

                c = a + b;
                b = c;
            }
        }
    }
}
