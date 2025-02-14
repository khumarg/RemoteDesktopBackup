using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class LambdaClass
    {

        public void Method4()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evens = data.Where(x => x %2 == 0).ToArray();

            foreach (int x in evens)
            {
                Console.WriteLine(x + " ");
            }
        }
        public void Method3()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> squares = data.Select(x => x * x).ToList();

            foreach (int x in squares)
            {
                Console.WriteLine(x + " ");
            }
        }
        public void Method1()
        {
            int[] data = { 20, 10, 4, 229, 942, 33, 2, 90, 43, 40 };

            var info = data.TakeWhile(x => x < 1000);

            Console.WriteLine(string.Join(", ", info));

            //foreach (var x in info)
            //{
            //    Console.WriteLine(x);
            //}
        }

        public void Method2()
        {
            List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNums = data.FindAll(x => x % 2 == 0);

            foreach (int i in evenNums)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
