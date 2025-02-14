using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.Models;

namespace BankProject.StudentRepo
{
    internal interface IStudent
    {
        public void GetStudentDetails();
        public void GetStudentDetailsByID(int id);
        public void AddStudent(Student student);
        public void RemoveStudent(int id);
        public void UpdateStudent(int id, float marks);

    }
}
