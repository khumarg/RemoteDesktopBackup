using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Models
{
    internal class Bank
    {
        public int CID { get; set; }
        public string CName { get; set; }
        public string AccType { get; set; }
        public float Balance { get; set; }
        public string Country { get; set; }
    }
}
