using StockManagement.Models;

namespace StockManagement.Services.Interfaces
{
    public interface IOrderItem
    {
        List<OrderItem> GetAll();
        OrderItem GetById(Guid id);
        void Create(OrderItem orderItem);
        OrderItem Update(OrderItem orderItem);
        void Delete(Guid id);
    }
}
