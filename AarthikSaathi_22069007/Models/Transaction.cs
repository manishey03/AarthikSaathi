using System;
using System.Collections.Generic;

namespace AarthikSaathi_22069007.Models
{
    public class Transaction
    {
        
        public int TransactionId { get; set; }
        public int UserId { get; set; }       
        public decimal Amount { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public string TransactionTitle { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
        public string Notes { get; set; } = string.Empty;
        public DateTime? DueDate { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
