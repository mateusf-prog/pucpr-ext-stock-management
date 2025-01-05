namespace StockManagement.Models
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Customer Customer { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public DateTime? CreatedDate { get; private set; }

        public Order(Customer customer, List<OrderItem> items)
        {
            this.Customer = customer;
            this.Items = items;
            this.CreatedDate = DateTime.Now;
        }
    }
}
