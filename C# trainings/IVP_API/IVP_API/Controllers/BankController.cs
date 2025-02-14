using System.ComponentModel;
using System.Diagnostics;
using IVP_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IVP_API.Controllers
{ 

    [Route("api/[controller]")]
    //[Route("ivp/[controller]")]             // one controller can have multiple routes
    [ApiController]
    public class BankController : ControllerBase
    {
        List<Bank> customers;

        public BankController()
        {
            customers = new List<Bank>()
            {
                new Bank() { CID = 10, CName = "Nikhil", Account = "Saving", Balance = 50000f },
                new Bank() { CID = 20, CName = "Jack", Account = "Joint", Balance = 25000f},
                new Bank() { CID = 30, CName = "Amit", Account = "Current", Balance = 40000f},
                new Bank() { CID = 40, CName = "Rose", Account = "Saving", Balance = 30000f},
                new Bank() { CID = 50, CName = "Neha", Account = "Joint", Balance = 20000f}
            };
        }

        [HttpGet("Customers")]
        public ActionResult<Bank> GetAllCustomers()
        {
            if(customers == null)
            {
                return BadRequest();
            } else
            {
                return Ok(customers.OrderBy(x => x.Balance).ToList());
            }
            
        }

        [HttpGet("Customer/{id:int:min(10)}")]
        public ActionResult<Bank> GetCustomerByID(int id)
        {
            var data = customers.Find(x => x.CID == id);

            if(data == null)
            {
                return NotFound();
            } else
            {
                return Ok(data);
            }
        }

        [HttpGet]
        [Route("CustomerName/{id:int:min(10)}")]
        public IActionResult GetCustomerName(int id)
        {
            var data = customers.Find(x => x.CID == id);
            if (id > 1000)
            {
                return NotFound();
            }
            else if (data == null)
            {
                return BadRequest();
            } else
            { 
                    return Ok(data.CName);
            }
        }

        [HttpGet("Balance/{id:int:min(10)}")]
        public IActionResult GetCustomerBalance(int id)
        {
            if(id == null)
            {
                return BadRequest();
            } else
            {
                var data = customers.Find(x => x.CID == id);

                return Ok(data.Balance);
            }
            
        }

        [HttpGet]
        [Route("{account:alpha}")]
        public IActionResult GetCustomerByAccount(string account)
        {
            if(account == null)
            {
                return BadRequest();
            } else
            {
                var data = customers.Where(x => x.Account == account);

                return Accepted(data);
            }
        }

        //[HttpGet("Customers")]
        //public List<Bank> GetAllCustomers()
        //{
        //    return customers.OrderBy(x => x.Balance).ToList();
        //}

        //[HttpGet("Customer/{id:int:min(10)}")]
        //public Bank GetCustomerByID(int id)
        //{
        //    var data = customers.Find(x => x.CID == id);

        //    return data;
        //}

        //[HttpGet]
        //[Route("CustomerName/{id:int:min(10)}")]
        //public string GetCustomerName(int id)
        //{
        //    var data = customers.Find(x => x.CID == id);

        //    return data.CName;
        //}

        //[HttpGet("Balance/{id:int:min(10)}")]
        //public double GetCustomerBalance(int id)
        //{
        //    var data = customers.Find(x => x.CID == id);

        //    return data.Balance;
        //}

        //[HttpGet]
        //[Route("{account:alpha}")]
        //public IEnumerable<Bank> GetCustomerByAccount(string account)
        //{
        //    var data = customers.Where(x => x.Account == account);

        //    return data;
        //}

        //[HttpGet]
        ////[Route("Balance/{balance:float:min(0):max(999999999999)}")]
        //[Route("Balance/{balance:float:range(0, 99999999999)}")]
        //public string GetCustomerByBalance(float balance)
        //{
        //    return $"Customer Details > {balance}";
        //}

        //// getting details through variables
        //[HttpGet]
        //[Route("Customers/{accType}/Balance/{amount}")]
        //public string GetCustomerByAccountAndBalance(string accType, float amount)
        //{
        //    return $"Customer details with {accType} and balance greater than {amount} is returned";
        //}

        //[HttpGet]
        //[Route("Customers")]
        //public string GetCustomerDetails()
        //{
        //    return "Customer Details Returned...";
        //}

        ////getting details through Query String
        //[HttpGet]
        //[Route("Details")]
        //public string GetCustomerDetails(string accType, float amount)
        //{
        //    return $"Customer details with {accType} and balance greater than {amount} is returned";
        //}

        //[HttpGet]
        //[Route("email")]
        //public string GetCustomerDetailsByEmail(string email)
        //{
        //    return $"Customer details with {email} is returned";
        //}

        //[HttpGet]
        //[Route("Customer/{id}")]
        //public string GetCustomerByID(int id)
        //{
        //    return $"Customer details with {id} is returned";
        //}

        ////[HttpGet("Customers/{accType:minLength(5):maxlength(10)}")]
        //[HttpGet("Customers/{accType:regex(IVP(S|C|D|J))}")]
        //public string GetCustomerByAccType(string accType)
        //{
        //    return $"Customer details with {accType} is returned";
        //}

        //[HttpGet("Accounts")]
        //public List<string> GetAccountTypes()
        //{
        //    List<string> types = new List<string>() { "Saving", "Current", "Joint" };

        //    return types;
        //}

        //[HttpGet]
        //[Route("Employees")]
        //[Route("Emps")]
        //[Route("IVP/Employees")]
        //public List<Employee> GetEmployees()
        //{
        //    var emps = new List<Employee>()
        //    {
        //        new Employee() { Id = 10, Name = "Nikhil", Salary = 5000f },
        //        new Employee() { Id = 20, Name = "Jack", Salary = 20000f },
        //        new Employee() { Id = 30, Name = "Rose", Salary = 30000f }
        //    };

        //    return emps;
        //}

        //[HttpGet]
        //[Route("~/State")]          // overriding Route
        //public string GetDetailsByState(string name)
        //{
        //    return $"Customer details returned for {name}";
        //}
    }
}
