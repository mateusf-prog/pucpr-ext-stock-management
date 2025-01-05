namespace StockManagement.Models
{
    public class OrderItem
    {
        public Guid Id { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public OrderItem(Product product, int quantity, decimal price)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}
