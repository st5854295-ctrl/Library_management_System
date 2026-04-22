namespace SmartLibrarySystem.Models;

public class Member
{
    public int MemberId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int BorrowedBooksCount { get; set; }
}
