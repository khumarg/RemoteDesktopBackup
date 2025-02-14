using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal static class Logger
    {
        public static void LogMessage(string message)
        {
            string filepath = ConfigurationManager.AppSettings["path"];

            using(StreamWriter writer = new StreamWriter(filepath, true))
            {
                writer.WriteLine(DateTime.Now.ToString() + " - " + message);
            }
        }
    }
}
