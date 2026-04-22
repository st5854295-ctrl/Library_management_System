using System;

namespace SmartLibrarySystem.Models;

public class IssueRecord
{
    public int IssueId { get; set; }
    public int BookId { get; set; }
    public int MemberId { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public decimal FineAmount { get; set; }
    public string Status { get; set; } = "Issued"; // "Issued", "Returned"
}
