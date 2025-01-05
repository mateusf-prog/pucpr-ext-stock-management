using StockManagement.Models.Enums;

namespace StockManagement.Models
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int StockQuantity { get; private set; }
        public decimal Price { get; private set; }
        public string Desctription { get; private set; }
        public Categorie Categorie { get; private set; }

        public Product(string name, int stockQuantity, decimal price, string description, Categorie categorie = Categorie.Other)
        {
            this.Name = name;
            this.StockQuantity = stockQuantity;
            this.Price = price;
            this.Desctription = description;
            this.Categorie = categorie;
        }
    }
}
