namespace AarthikSaathi_22069007.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PreferredCurrency { get; set; } = "USD";
    }
}
