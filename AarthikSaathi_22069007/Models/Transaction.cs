using System;
using System.Collections.Generic;

namespace AarthikSaathi_22069007.Models
{
    public class Transaction
    {
        /// <summary>
        /// Unique identifier for the transaction.
        /// </summary>
        public int TransactionId { get; set; }

        /// <summary>
        /// Identifier for the user who created the transaction.
        /// </summary>
        public int UserId { get; set; } // Foreign Key linking to User

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Type of transaction: "credit", "debit", or "debt".
        /// </summary>
        public string TransactionType { get; set; } = string.Empty;

        /// <summary>
        /// Title or description of the transaction.
        /// </summary>
        public string TransactionTitle { get; set; } = string.Empty;

        /// <summary>
        /// Optional tags to categorize the transaction (e.g., "groceries", "rent").
        /// </summary>
        public List<string> Tags { get; set; } = new();

        /// <summary>
        /// Optional notes for additional details about the transaction.
        /// </summary>
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// Due date for debt transactions. Null for other transaction types.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Date and time when the transaction was created.
        /// </summary>
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
