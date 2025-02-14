using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IVP_ConsoleApp1
{
    internal class ConcurrentCollection
    {
        public void CCBagDemo()
        {
            ConcurrentBag<string> bg = new ConcurrentBag<string>();

            ConcurrentBag<int> bag2 = new ConcurrentBag<int>()
            {
                10, 20, 30, 40, 50
            };

            bg.Add("India");
            bg.Add("Ireland");
            bg.Add("Sweden");

            foreach (var item in bg)
            {
                Console.WriteLine(item);
            }

            string str = "";
            bg.TryTake(out str);

            Console.WriteLine($"Removed {str}");

            string[] arr = new string[bg.Count];

            bg.CopyTo(arr, 0);

            Console.WriteLine("Array elements - ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            bg.TryPeek(out str);
            Console.WriteLine("Peek element - " + str);
        }
        public void CCQueueDemo()
        {
            ConcurrentQueue<string> cq = new ConcurrentQueue<string>();
            cq.Enqueue("India");
            cq.Enqueue("UK");
            cq.Enqueue("USA");
            cq.Enqueue("Australia");

            foreach (var item in cq)
            {
                Console.WriteLine(item);
            }

            string str = "";
            cq.TryDequeue(out str);

            Console.WriteLine($"\nAfter popping - {str}");
            foreach (var item in cq)
            {
                Console.WriteLine(item);
            }

            // storing queue elements in an array
            string[] arr = new string[cq.Count];
            cq.CopyTo(arr, 0);

            Console.WriteLine("\narray elements - ");
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            // TryPeek
            string str1 = "";
            cq.TryPeek(out str1);

            Console.WriteLine("Peek element - " + str1);

            //Concurrent Queue with objects

            ConcurrentQueue<ICICICustomer> customers = new ConcurrentQueue<ICICICustomer>();
            customers.Enqueue(new ICICICustomer() { ID = 10, Name = "Nikhil", AccType = "Saving", Balance = 1234567 });
            customers.Enqueue(new ICICICustomer() { ID = 20, Name = "Jack", AccType = "Current", Balance = 1213232 });
            customers.Enqueue(new ICICICustomer() { ID = 30, Name = "Rose", AccType = "Joint", Balance = 4353534 });

            foreach (var item in customers)
            {
                Console.WriteLine($"Customer details: {item.ID} - {item.Name} - {item.AccType} - {item.Balance}");
            }

        }
        public void CCStackDemo()
        {
            ConcurrentStack<string> cs = new ConcurrentStack<string>();
            cs.Push("India");
            cs.Push("USA");
            cs.Push("UK");
            cs.Push("Japan");

            foreach (var item in cs)
            {
                Console.WriteLine(item);
            }

            string[] data = { "Australia", "Russia" };
            cs.PushRange(data);

            foreach (var item in cs)
            {
                Console.WriteLine(item);
            }

            string str = "";
            bool x = cs.TryPop(out str);
            Console.WriteLine(x + "Removed " + str);

            foreach (var item in cs)
            {
                Console.WriteLine(item);
            }

            string[] info = new string[3];
            int num = cs.TryPopRange(info);

            Console.WriteLine("No of pops - " + num);

            foreach (var item in cs)
            {
                Console.WriteLine(item);
            }

            string str1 = "";
            cs.TryPeek(out str1);
            Console.WriteLine("Top element - " + str1);

            string[] arr = new string[3];
            cs.CopyTo(arr, 0);

            Console.WriteLine("Array elements - ");
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public void ConcurrentDictionary()
        {
            ConcurrentDictionary<string, string> cd = new ConcurrentDictionary<string, string>();
            cd.TryAdd("India", "Delhi");
            cd.TryAdd("USA", "Washington DC");
            cd.TryAdd("UK", "London");

            foreach (var str in cd)      // str is KeyValuePair<string, string> type.
            {
                Console.WriteLine($"{str.Key} - {str.Value}");
            }

            bool a = cd.TryAdd("India", "Mumbai");

            for(int i=0; i<cd.Count; i++)
            {
                string key = cd.Keys.ElementAt(i);
                string value = cd[key];

                Console.WriteLine($"{key} - {value}");
            }

            // ContainsKey

            if(cd.ContainsKey("USA"))
            {
                Console.WriteLine("USA is present in the Dict.");
            } else
            {
                Console.WriteLine("USA is NOT present in the Dict.");
            }

            // TryRemove
            
            string capital = string.Empty;
            bool z = cd.TryRemove("USA", out capital);
            Console.WriteLine(z + " - " + capital);

            z = cd.TryRemove("China", out capital);
            Console.WriteLine(z + " - " + capital);

            // AddOrUpdate
            cd.AddOrUpdate("Sri Lanka", "Columbo", (k, v) => "New State");
            cd.AddOrUpdate("Sri Lanka", "Columbo", (k, v) => "New State");

            foreach (var str in cd)      
            {
                Console.WriteLine($"{str.Key} - {str.Value}");
            }

            cd.Clear();
            Console.WriteLine(cd.Count);
        }
    }
}
