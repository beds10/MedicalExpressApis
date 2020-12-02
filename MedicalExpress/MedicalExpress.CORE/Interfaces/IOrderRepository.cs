using MedicalExpress.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IOrderRepository
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
