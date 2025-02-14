using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal interface IBank
    {
        public void CreateAccount();        // by default public
        public void UpdateAccount();
        public void DeleteAccount();

    }

    internal interface ILoan
    {
        public void HomeLoan();
        public void CarLoan();
        public void StudyLoan();

    }

    internal class Customer : IBank, ILoan
    {
        public void CreateAccount()
        {
            Console.WriteLine("Customer Account Created");
        }

        public void HomeLoan()
        {
            Console.WriteLine("Home Loan Granted @ 2%");
        }

        public void UpdateAccount()
        { }

        public void DeleteAccount()
        { }

        public void CarLoan()
        { }

        public void StudyLoan()
        { }
    }

    public class StudentAccount : IBank, ILoan
    {
        public void CreateAccount()
        {
            Console.WriteLine("Student Account Created");
        }

        public void HomeLoan()
        { }

        public void UpdateAccount()
        { }

        public void DeleteAccount()
        { }

        public void CarLoan()
        { }

        public void StudyLoan()
        {
            Console.WriteLine("Study Loan Granted @ 5%");
        }
    }
}
