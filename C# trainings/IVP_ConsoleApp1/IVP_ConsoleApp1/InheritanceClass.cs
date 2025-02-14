using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class BankAccount
    {
        int cid;
        string name;

        protected BankAccount()
        {
            Console.WriteLine("Please Enter Details: ");
            cid = int.Parse(Console.ReadLine());
            name = Console.ReadLine();
        }

        protected void DisplayDetails()
        {
            Console.WriteLine($"Welcome Customer: {cid} - {name}");
        }

        public virtual void loan()
        {
            Console.WriteLine("IVP provides Personal Loan @ 15% interest rate");
        }
    }

    internal class SavingAccount : BankAccount
    {
        string accType;
        float balance;
        public SavingAccount() : base()
        {
            accType = Console.ReadLine();
            balance = float.Parse(Console.ReadLine());
        }

        public void DisplaySBAccountDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"SB Details: {accType} - {balance}");
        }

        public override void loan()
        {
            Console.WriteLine("IVP provides Loan on Saving Account @ 8% interest rate");
        }
    }

    internal class CurrentAccount : BankAccount
    {
        string accType;
        string companyName;
        float balance;
        public CurrentAccount() : base()
        {
            accType = Console.ReadLine();
            companyName = Console.ReadLine();
            balance = float.Parse(Console.ReadLine());
        }

        public void DisplayCBAccountDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"CB Details: {accType} - {balance} - {companyName}");
        }

        public override void loan()
        {
            Console.WriteLine("IVP provides Loan on Current Account @ 10% interest rate");
        }
    }

    internal class AddOnAccounts : SavingAccount 
    {
        string childName;
        float addOnBalance;
        public AddOnAccounts() : base()
        {
            childName = Console.ReadLine();
            addOnBalance = float.Parse(Console.ReadLine());
        }

        public void DisplayAddOnDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Add On Details: {childName} - {addOnBalance}");
        }

        public override void loan()
        {
            Console.WriteLine("IVP provides Study Loan on AddOn Account @ 5% interest rate");
        }
    }
    internal class InheritanceClass
    {

    }
}
