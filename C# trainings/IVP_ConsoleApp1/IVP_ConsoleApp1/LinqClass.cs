using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class LinqClass
    {
        public void LinqMethods()
        {
            List<IVPStudent> list = new List<IVPStudent>()
            {
                new IVPStudent() { SID = 10, Name = "Nikhil", Marks = 90f },
                new IVPStudent() { SID = 20, Name = "Rose", Marks = 80f },
                new IVPStudent() { SID = 30, Name = "Nikhil", Marks = 60f },
                new IVPStudent() { SID = 40, Name = "Jack", Marks = 50f },
                new IVPStudent() { SID = 50, Name = "Sonia", Marks = 70f }
            };

            List<Branch> branch = new List<Branch>()
            {
                new Branch() { SID = 10, BranchName = "Electrical" },
                new Branch() { SID = 20, BranchName = "CS" },
                new Branch() { SID = 30, BranchName = "IT" },
                new Branch() { SID = 40, BranchName = "IT" },
                new Branch() { SID = 50, BranchName = "CS" }
            };

            var details = from s in list
                          from b in branch
                          where s.SID == b.SID
                          select new { s.SID, s.Name, b.BranchName, s.Marks };

            var details2 = list.Join(branch, s => s.SID, b => b.SID, (s, b) => new
            {
                s.SID,
                s.Name,
                b.BranchName,
                s.Marks
            });

            var nStudents = list.Where(s => s.Name.StartsWith("N"));

            foreach (var student in nStudents)
            {
                Console.WriteLine($"{student.SID} - {student.Name} - {student.Marks}");
            }

            foreach(var item in details2)
            {
                Console.WriteLine($"{item.SID} - {item.Name} - {item.BranchName} - {item.Marks}");
            }

            // Method Syntax
            //var std = list.Where(s => s.Marks >= 60 && s.Marks <= 90);

            //foreach ( var s in std )
            //{
            //    Console.WriteLine( s.Name+ " - " + s.Marks);
            //}

            // Query Syntax
            //var info = from s in list
            //           where s.Name == "Nikhil"
            //           select s;

            //var info = list.Where(a => a.Marks > 50).Where(a => a.Marks < 75);

            //var info = from s in list
            //           where s.Marks > 50
            //           where s.Marks < 75
            //           select s;

            //var info = list.OrderByDescending(x => x.Name).ThenBy(x => x.Marks).ToList();

            var info1 = from s in list
                        orderby s.Name, s.Marks descending
                        select new { s.Name, s.Marks };

            var avg = list.Average(s => s.Marks);
            var max = list.Max(s => s.Marks);
            var min = list.Min(s => s.Marks);
            var sum = list.Sum(s => s.Marks);

            var std1 = list.Find(s => s.SID == 10);
            //Console.WriteLine(std1.SID + " - " +  std1.Name);


            //foreach (var s in info1)
            //{
            //    Console.WriteLine(s.SID + " - " + s.Name + " - " + s.Marks);
            //}

            //foreach (IVPStudent student in list)
            //{
            //    Console.WriteLine(student.Name);
            //}
        }
    }
}
