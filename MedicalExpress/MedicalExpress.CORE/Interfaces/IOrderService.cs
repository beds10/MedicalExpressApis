using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<IEnumerable<Order>> GetSessionToken(string id);

        Task<IEnumerable<Order>> GetOrderByUser(int id);
        Task<Order> GetOrder(int id);

        Task InsertOrder(Order order);
        Task<bool> UpdateOrder(Order order);
        Task<bool> DeleteOrder(int id);
    }
}