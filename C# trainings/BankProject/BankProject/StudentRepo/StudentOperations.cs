using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BankProject.Models;

namespace BankProject.StudentRepo
{
    internal class StudentOperations : IStudent
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public void GetStudentDetails()
        {

        }

        public void GetStudentDetailsByID(int id)
        {

        }

        public void AddStudent(Student student)
        {

        }

        public void RemoveStudent(int id)
        {

        }

        public void UpdateStudent(int id, float marks)
        {

        }

    }
}
