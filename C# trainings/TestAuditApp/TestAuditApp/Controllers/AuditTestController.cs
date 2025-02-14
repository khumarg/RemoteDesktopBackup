using Microsoft.EntityFrameworkCore;
using TestAuditApp.Models;

namespace TestAuditApp.Controllers
{
    public class AuditTestController
    {
        SmtestContext _context;

        public AuditTestController(SmtestContext context)
        {
            _context = context;
        }
        public void LogAudit(string TableName, string ActionType, string OldValue, string NewValue)
        {
            var audit = new AuditTest
            {
                TableName = TableName,
                ActionType = ActionType,
                OldValue = OldValue,
                NewValue = NewValue,
                TimeStamp = DateTime.Now.ToString()
            };

            _context.AuditTests.Add(audit);
            _context.SaveChanges();
        }
    }
}
