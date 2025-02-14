using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class ModifierClass
    {
        public void GetDetails()
        {
            Console.WriteLine("Get Details of customer");
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            Console.WriteLine("Display details of customer");
        }
    }
}
