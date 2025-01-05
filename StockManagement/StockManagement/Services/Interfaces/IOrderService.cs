using StockManagement.Models;

namespace StockManagement.Services.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(Guid id);
        void Create(Order order);
        Order Update(Order order);
        void Delete(Guid id);
        void ChangeStatus(Guid id, Status status);
    }
}
