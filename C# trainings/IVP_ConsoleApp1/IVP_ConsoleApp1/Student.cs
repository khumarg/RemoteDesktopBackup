using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class Student
    {
        private int sid;
        private string sname;
        private string branch;
        private float marks;

        public string Country { get; set; }

        public int Sid
        {
            get { return sid; } //old style
            set { sid = value; }
        }

        public string Sname
        {
            get { return sname.ToUpper(); }
            set { sname = value; }
        }

        public string Branch
        {
            get => branch;
            set => branch = value;
        }

        public float Marks
        {
            get { return marks * 2; }
            set { marks = value; } 
        }

        public void getDetails()
        {
            Sid = 10;
            Sname = "Nikhil";
            Branch = "Electrical";
            Marks = 90;
            Country = "India";

            Console.WriteLine($"Student Details: {Sid} - {Sname} - {Branch} - {Marks} - {Country}");
        }

        public void getDetails2()
        {
            Console.WriteLine($"Student Details: {Sid} - {Sname} - {Branch} - {Marks} - {Country}");
        }
    }
}
