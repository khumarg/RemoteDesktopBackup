using BankProject.BankRepo;
using BankProject.Controllers;
using BankProject.Models;

namespace BankProject
{
    internal class LoanCalc
    {
        public void HomeLoanInterest(int a)
        {
            Console.WriteLine("Home Loan Monthly EMI: " + (a * 0.1));
        }

        public void CarLoanInterest(int a)
        {
            Console.WriteLine("Car Loan Monthly EMI: " + (a * 0.15));
        }

        public void StudyLoanInterest(int a)
        {
            Console.WriteLine("Study Loan Monthly EMI: " + (a * 0.05));
        }

        public void PersonalLoanInterest(int a)
        {
            Console.WriteLine("Personal Loan Monthly EMI: " + (a * 0.2));
        }
    }
    internal class Program
    {
        public delegate void SBAccountDelegate();               //delegate
        public delegate void CUAccountDelegate();               //delegate
        public delegate void DebitCardDelegate();               //delegate

        public delegate void Loan(int a);

        public static event SBAccountDelegate OpenSBAccount;           //event
        public static event CUAccountDelegate OpenCUAccount;           //event

        public static event Loan CalculateEMI;
        static void Main(string[] args)
        {
            int a = 10, b = 0;

            try
            {
                //int c = a / b;

                int[] arr = { 1, 2, 3, 4, 5 };

                for(int i=0; i<10; i++)
                {
                    Console.Write(arr[i] + ", ");
                }
            }
            catch (Exception e)
            {
                Logger.LogMessage(e.Message);
            }

            //Console.WriteLine("Events and Delegates");

            //LoanCalc lc = new LoanCalc();

            //Loan l = new Loan(lc.HomeLoanInterest);
            //l += new Loan(lc.CarLoanInterest);
            //l += new Loan(lc.StudyLoanInterest);
            //l += new Loan(lc.PersonalLoanInterest);

            //CalculateEMI = l;
            //CalculateEMI(20000);

            //AccountClass acc = new AccountClass();

            //DebitCardDelegate card = new DebitCardDelegate(acc.GetDebitCard);

            //card();

            //SBAccountDelegate sb = new SBAccountDelegate(acc.GetDocuments);
            //sb += new SBAccountDelegate(acc.VerifyDocuments);
            //sb += new SBAccountDelegate(acc.CreateSavingAccount);
            //sb += new SBAccountDelegate(acc.GetDebitCard);

            ////sb.Invoke();
            //OpenSBAccount = sb;
            //OpenSBAccount.Invoke();

            //CUAccountDelegate cu = new CUAccountDelegate(acc.GetDocuments);
            //cu += new CUAccountDelegate(acc.VerifyDocuments);
            //cu += new CUAccountDelegate(acc.CreateCurrentAccount);
            //cu += new CUAccountDelegate(acc.DepositInitialBalance);
            //cu += new CUAccountDelegate(acc.GetDebitCard);

            //cu -= acc.DepositInitialBalance;
            ////cu();

            //OpenCUAccount = cu;
            //OpenCUAccount.Invoke();

            //Console.WriteLine("IVP Bank Project");

            //IBank ibank = new BankOperations();
            //BankController control = new BankController(ibank);

            //control.GetBankCustomer();
            //control.GetBankCustomerByAccount("Saving");
            //control.AddBankCustomer(new Bank()
            //{
            //    CID = 300, CName = "Avni", AccType = "Saving", Balance = 100000f, Country = "India"
            //});
            //control.UpdateBankCustomer(300, 6000000);
            //control.RemoveBankCustomer(200);

            Console.ReadKey();
        }
    }
}
