using StockManagement.Models;

namespace StockManagement.Services.Interfaces
{
    public interface IUserService
    {
        bool Login(string username, string password);
        void Create(User user);
        void Delete(User user);
    }
}
