using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.Models;

namespace BankProject.BankRepo
{
    internal interface IBank
    {
        public Task GetAllCustomers();
        public Task GetCustomerByAccType(string type);
        public Task<int> AddCustomer(Bank customer);
        public Task<int> UpdateCustomer(int id, float balance);
        public Task<int> DeleteCustomer(int id);
    }
}
