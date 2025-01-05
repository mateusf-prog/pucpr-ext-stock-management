using StockManagement.Models;

namespace StockManagement.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(Guid id);
        void Create(Customer customer);
        Customer Update(Customer customer);
        void Delete(Guid id);
    }
}
