using TableLib;
namespace IVP_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object of class
            LambdaClass lc = new LambdaClass();
            //lc.Method1();
            //lc.Method2();
            lc.Method3();

            //LinqClass lc = new LinqClass();
            //lc.LinqMethods();

            // Concurrent Collections
            //ConcurrentCollection c1 = new ConcurrentCollection();
            //c1.ConcurrentDictionary();
            //c1.CCStackDemo();
            //c1.CCQueueDemo();
            //c1.CCBagDemo();


            //Thread t1 = new Thread(ThreadSafe.Method1);

            //Thread t2 = new Thread(ThreadSafe.Method2);

            //t1.Start();
            //t2.Start();

            //ThreadSafe.Method3();

            //CollectionClass cc = new CollectionClass();
            //cc.NonGeneric();
            //cc.HashSetDemo();
            //cc.StackDemo();
            //cc.QueueDemo();
            //cc.LinkedListDemo();
            //cc.DictionaryDemo();
            //cc.SortedDictionaryDemo();
            //cc.SortedListDemo();

            // File Handling
            //FileHandling fs = new FileHandling();
            //fs.FileCreate();
            //fs.FileRead();
            //fs.DirectoryDetails();
            //fs.DirectoryMethods();
            //fs.FileInfoMethods();
            //fs.BinaryFileHandling();
            //fs.FileMethods();

            //Exception Handling
            //int[] marks = { 10, 20, 30, 40, 50 };
            //ExceptionHandling exception = new ExceptionHandling();
            //exception.Divide(10, 0);
            //exception.ArrayAddition(marks);
            //exception.GetStudentDetails();
            //try
            //{
            //    exception.Voting();
            //}
            //catch (AgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //exception.FileCreation();

            //ICalc calc = new IVPCalc();
            //ISciCalc scalc = new IVPCalc();

            //calc.Addition(10, 20);
            //scalc.Addition(20, 30);
            //scalc.Subtraction(30, 20);

            //HDFCSavingAccount sbAcc = new HDFCSavingAccount();
            //sbAcc.IssueDebitCard();
            //sbAcc.IssueCreditCard();

            //HDFCCurrentAccount cuAcc = new HDFCCurrentAccount();
            //cuAcc.IssueDebitCard();

            //DebitCard cc = new HDFCCurrentAccount();
            //cc.IssueCreditCard();

            //IVPSavingAccount sb = new IVPSavingAccount();
            //IVPCurrentAccount cu = new IVPCurrentAccount();

            //IVPAccount acc = new IVPAccount();
            //acc.PrintAccounts(sb);

            //acc = new IVPAccount();
            //acc.PrintAccounts(cu);

            //acc.account = sb;
            //sb.PrintData();

            //IAccount demat = new IVPDemantAccount();
            //acc = new IVPAccount();
            //acc.PrintAccounts(demat);


            //IBank bank = new Customer();
            //bank.CreateAccount();

            //ILoan hl = new Customer();
            //hl.HomeLoan();

            //bank = new StudentAccount();
            //bank.CreateAccount();

            //hl = new StudentAccount();
            //hl.StudyLoan();

            //BankAccount ba = new AddOnAccounts();
            //ba.loan();

            //AddOnAccounts acc = new AddOnAccounts();
            //acc.DisplayAddOnDetails();

            //acc.loan();

            //SavingAccount acc = new SavingAccount();
            //acc.DisplaySBAccountDetails();

            //CurrentAccount acc = new CurrentAccount();
            //acc.DisplayCBAccountDetails();

            //Employee e1 = new Employee();
            //Employee e2 = new Employee(20, "Sonia", 900000);
            //Employee e3 = new Employee("Neha", 30, 800000);
            //e1.DisplayEmpDetails();
            //e2.DisplayEmpDetails();
            //e3.DisplayEmpDetails();


            //Student std = new Student();

            //std.getDetails();
            //std.Sid = 20;
            //std.Sname = "Sonia";
            //std.Branch = "CS";
            //std.Marks = 95f;
            //std.Country = "USA";
            //std.getDetails2();

            //MethodClass method1 = new MethodClass();
            //int x = 2;
            //int cube = 0, quadra = 0;
            //Console.WriteLine($"x = {x}");
            //int p = method1.Data3(ref x, out cube, out quadra);
            //Console.WriteLine($"cube = {cube}");
            //Console.WriteLine($"quadra = {quadra}");
            //Console.WriteLine($"p = {p}");

            //method1.addition();
            //method1.addition(10, 20);
            //method1.addition(500f, 300);
            //method1.addition(500f, 300f);
            //Console.WriteLine(method1.multiply(50, 30, 20));

            //ArrayClass aobj = new ArrayClass();
            //aobj.Test(10, "Nikhil", 50000.678d, "Manager", 'M', 1234.45f);

            //aobj.Info("Amit", "Suresh", "Nikhil");
            //aobj.Info("Amit", "Suresh", "Nikhil", "Rita");
            //aobj.Info("Amit", "Suresh", "Nikhil", "Rita", "Ritesh");

            //aobj.GetArrayUsingLoop();
            //aobj.CopyData();
            //LoopsAndConstructs obj = new LoopsAndConstructs();
            //obj.numbersExcept3and6();

            //ModifierClass mod = new ModifierClass();

            //mod.GetDetails();
            //mod.DisplayDetails();

            //obj.ForDemo();
            //obj.evenNumbers();
            //obj.oddNumbers();
            //obj.table(19);

            //obj.fibbonacci(5);

            //Class1 c1 = new Class1();

            //c1.table(13);
            //c1.ForDemo();

            //obj.ConstructSwitchCase();

            //obj.ConstructIfElse();

            //obj.ConstructElseIf();

            //Calculator calc1 = new Calculator();
            //Calculator calc2 = new Calculator();

            //calc1.Addition();
            //calc2.Addition();

            //calc1.GetChar();

            //calc.Test();
            //calc.Addition();
            //calc.Subtraction();
            //calc.Multiply();

            //int a = 10, b = 20;
            //int c = a + b;
            //Console.WriteLine("Addition: " + c);
            //Console.WriteLine($"Addition: {c}"); //string interpolation

            //Console.WriteLine($"Addition of {a} and {b} = {c}");

            //char data = '#';
            //Console.WriteLine($"Character: {data}");

            //float l = 30, m = 40;
            //float n = l + m;
            //Console.WriteLine($"Addition of {l} and {m} = {n}");

            //double x = 300d, y = 400d;      //used in .NET 7.0 or before
            //Console.WriteLine($"Addition of {x} and {y} = {x+y}");


        }
    }
}
