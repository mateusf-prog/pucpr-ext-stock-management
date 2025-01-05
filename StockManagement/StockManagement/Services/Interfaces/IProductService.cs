using StockManagement.Models;

namespace StockManagement.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(Guid id);
        void Create(Product product);
        Product Update(Product product);
        void Delete(Guid id);
        void ChangeStock(Guid productId, int newWuantity);
    }
}
