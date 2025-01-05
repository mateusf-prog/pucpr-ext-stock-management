namespace StockManagement.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string? Email { get; private set; }
        public string? Password { get; private set; }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
