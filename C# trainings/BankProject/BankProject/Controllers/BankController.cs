using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.BankRepo;
using BankProject.Models;

namespace BankProject.Controllers
{
    internal class BankController
    {
        IBank _bank;

        public BankController(IBank bank)
        {
            _bank = bank;
        }

        public async Task GetBankCustomer()
        {
            await _bank.GetAllCustomers();
        }

        public async Task GetBankCustomerByAccount(string type)
        {
            await _bank.GetCustomerByAccType(type);
        }

        public async Task AddBankCustomer(Bank customer)
        {
            Console.WriteLine(await _bank.AddCustomer(customer) + " Records Inserted");
        }

        public async Task RemoveBankCustomer(int id)
        {
            Console.WriteLine(await _bank.DeleteCustomer(id) + " Records Deleted");
        }

        public async Task UpdateBankCustomer(int id, float bal)
        {
            Console.WriteLine(await _bank.UpdateCustomer(id, bal) + " Records Updated");
        }
    }
}
