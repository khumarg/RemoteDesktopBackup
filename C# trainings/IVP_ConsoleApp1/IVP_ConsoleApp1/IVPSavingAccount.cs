using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal interface IAccount
    {
        public void PrintData();
    }
    internal class IVPSavingAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Saving Account Details");
        }
    }

    internal class IVPCurrentAccount : IAccount 
    {
        public void PrintData()
        {
            Console.WriteLine("Current Account Details");
        }
    }

    //Dependency Injection
    internal class IVPAccount
    {
       IAccount account { get; set; }
       public void PrintAccounts(IAccount account)
       {
            account.PrintData();
       }
    }
}
