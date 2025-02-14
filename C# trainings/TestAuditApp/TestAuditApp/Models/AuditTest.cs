using System.ComponentModel.DataAnnotations;

namespace TestAuditApp.Models
{
    public class AuditTest
    {
        [Key]
        public int AuditID { get; set; }
        public string TableName { get; set; }
        public string TimeStamp { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string ActionType { get; set; }
    }
}
