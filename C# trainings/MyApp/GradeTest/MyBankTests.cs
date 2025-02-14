using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp;

namespace GradeTest
{
    public class MyBankTests
    {
        private MyBank _mybank { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _mybank = new MyBank(2000);
        }

        [Test]
        public void Adding_Funds_Updates_Balance()
        {
            _mybank.Add(1000);

            Assert.AreEqual(3000, _mybank.Balance);
        }

        [Test]
        public void Adding_Negative_Funds_Throws()
        {
            //Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _mybank.Add(-100));
        }

        [Test]
        public void Withdrawing_Funds_Updates_Balance()
        {
            _mybank.Withdraw(1500);

            Assert.AreEqual(500, _mybank.Balance);
        }

        [Test]
        public void Withdrawing_Negative_Funds_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _mybank.Withdraw(-500));
        }

        [Test]
        public void Withdrawing_More_Than_Balance_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _mybank.Withdraw(50000)); 
        }

        [Test]
        public void Transfering_Funds_Updates_Both_Accounts()
        {
            MyBank otheracc = new MyBank();
            _mybank.TransferFundsTo(otheracc, 500);

            Assert.AreEqual(1500, _mybank.Balance);
            Assert.AreEqual(500, otheracc.Balance);
        }

        [Test]
        public void Transfer_To_Non_Existing_Account_Throws()
        { 
            Assert.Throws<ArgumentNullException>(() => _mybank.TransferFundsTo(null, 500));
        }
    }
}
