using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //1.0
using System.Collections.Generic;    //2.0
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;    //4.0

namespace IVP_ConsoleApp1
{
    internal class CollectionClass
    {

        public void SortedListDemo()
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1, "India");
            list.Add(3, "USA");
            list.Add(2, "UK");
            list.Add(4, "China");
            list.Add(10, "Sri Lanka");
            list.Add(6, "Sweden");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void SortedDictionaryDemo()
        {
            SortedDictionary<int, string> dic = new SortedDictionary<int, string>();
            dic.Add(1, "India");
            dic.Add(3, "USA");
            dic.Add(2, "UK");

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public void DictionaryDemo()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "India");
            dic.Add(2, "USA");
            dic.Add(3, "UK");

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public void LinkedListDemo()
        {
            LinkedList<string> companies = new LinkedList<string>();
            companies.AddLast("Nikhil");
            companies.AddLast("Jack");
            companies.AddLast("Rose");
            companies.AddLast("Jack");
            companies.AddFirst("Aaryan");

            foreach (var item in companies)
            {
                Console.WriteLine(item);
            }

            LinkedListNode<string> node = companies.Find("Jack");
            companies.AddBefore(node, "Prachi");
            companies.AddAfter(node, "Rohit");

            Console.WriteLine('\n');
            foreach (var item in companies)
            {
                Console.WriteLine(item);
            }
        }
        public void StackDemo()
        {
            var names = new Stack<string>();
            names.Push("Nikhil");
            names.Push("Amit");
            names.Push("Jack");
            names.Push("Rose");

            // Iterate SortedSet elements using foreach loop 
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Pop();

            Console.WriteLine("\n");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void QueueDemo()
        {
            var names = new Queue<string>();
            names.Enqueue("Nikhil");
            names.Enqueue("Amit");
            names.Enqueue("Jack");
            names.Enqueue("Rose");

            // Iterate Queue elements using foreach loop 
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Dequeue();

            Console.WriteLine("\n");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        public void HashSetDemo()
        {
            var names = new SortedSet<string>();
            names.Add("Nikhil");
            names.Add("Amit");
            names.Add("Jack");
            names.Add("Rose");

            // Iterate SortedSet elements using foreach loop 
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            HashSet<String> list = new HashSet<String>();
            list.Add("Nikhil");
            list.Add("Jack");
            list.Add("Ravi");
            list.Add("Sonia");

            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            SortedSet<int> marks = new SortedSet<int>() { 80, 75, 80, 65, 90 };
            Console.WriteLine(marks);
            Console.WriteLine(marks.Count);

            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            ICICICustomer cust1 = new ICICICustomer()
            {
                ID = 10,
                Name = "Nikhil",
                AccType = "Saving",
                Balance = 343433f
            };
            ICICICustomer cust2 = new ICICICustomer()
            {
                ID = 20,
                Name = "Jack",
                AccType = "Joint",
                Balance = 10000f
            };
            ICICICustomer cust3 = new ICICICustomer()
            {
                ID = 30,
                Name = "Rose",
                AccType = "Current",
                Balance = 30000f
            };

            SortedSet<ICICICustomer> customers = new SortedSet<ICICICustomer>();
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);
            
            customers.Add(new ICICICustomer() { ID = 40, Name = "Neha", AccType = "Saving", Balance = 40000f });

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ID} - {customer.Name} - {customer.AccType} - {customer.Balance}");
            }
        }
        public void Generic()
        {
            List<String> list = new List<String>();
            list.Add("Nikhil");
            list.Add("Jack");
            list.Add("Ravi");
            list.Add("Sonia");

            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            List<int> marks = new List<int>() { 80, 75, 40, 65, 90 };
            Console.WriteLine(marks);
            Console.WriteLine(marks.Count);

            marks.Sort();

            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            ICICICustomer cust1 = new ICICICustomer()
            {
                ID = 10, Name = "Nikhil", AccType = "Saving", Balance = 343433f
            };
            ICICICustomer cust2 = new ICICICustomer()
            {
                ID = 20, Name = "Jack", AccType = "Joint", Balance = 10000f
            };
            ICICICustomer cust3 = new ICICICustomer()
            {
                ID = 30, Name = "Rose", AccType = "Current", Balance = 30000f
            };

            List<ICICICustomer> customers = new List<ICICICustomer>(3);
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);
            customers.Add(new ICICICustomer() { ID = 40, Name = "Neha", AccType = "Saving", Balance = 40000f });

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ID} - {customer.Name} - {customer.AccType} - {customer.Balance}");
            }
        }
        
        public void NonGeneric()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "India");
            ht.Add(2, "USA");
            ht.Add(3, "UK");
            ht.Add("India", "Delhi");
            ht.Add("Sri Lanka", "Columbo");

            Console.WriteLine("Key and values -");

            foreach (DictionaryEntry dd in ht)
            {
                Console.WriteLine($"{dd.Key} : {dd.Value}");
            }

            ht.Remove(3);

            foreach (DictionaryEntry dd in ht)
            {
                Console.WriteLine($"{dd.Key} : {dd.Value}");
            }

            // LIFO
            //Stack st = new Stack();
            //st.Push(1);
            //st.Push(2);
            //st.Push("Nikhil");
            //st.Push("Jack");

            //Console.WriteLine(st.ToString());
            //Console.WriteLine(st.Count);
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}

            //st.Pop();

            //Console.WriteLine(st.Count);
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}

            // FIFO
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue("Nikhil");

            //Console.WriteLine(queue.ToString());
            //Console.WriteLine(queue.Count);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //queue.Dequeue();

            //Console.WriteLine(queue.Count);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList al = new ArrayList();
            //al.Add(10);
            //al.Add("Khumar");
            //al.Add(20);
            //al.Add(30);
            //al.Add(500000.05d);
            //al.Add(true);
            //al.Add(false);
            //al.Add(null);
            //al.Add(399);
            //al.Add("Hello");

            //Console.Write(al);
            //Console.WriteLine(al.Count);
            //Console.WriteLine(al.Capacity);

            //foreach (var i in al)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
