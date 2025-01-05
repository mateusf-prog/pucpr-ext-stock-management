namespace StockManagement.Models
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public string? Document { get; private set; }
        public int Age { get; private set; }
        public string? PhoneNumber { get; private set; }

        public Customer(string name, string document, int age, string phoneNumber)
        {
            this.Name = name;
            this.Document = document;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
        }
    }
}
