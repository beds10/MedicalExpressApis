using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MedicalExpress.CORE.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> GetOrder(int id)
        {
            return await _orderRepository.GetOrder(id);
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await _orderRepository.GetOrders();
        }
        public async Task<IEnumerable<Order>> GetSessionToken(string id)
        {
            return await _orderRepository.GetSessionToken(id);
        }
        public async Task<IEnumerable<Order>> GetOrderByUser(int id)
        {
            return await _orderRepository.GetOrderByUser(id);
        }
        public async Task InsertOrder(Order order)
        {
            await _orderRepository.InsertOrder(order);
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            return await _orderRepository.UpdateOrder(order);
        }


        public async Task<bool> DeleteOrder(int id)
        {
            return await _orderRepository.DeleteOrder(id);
        }

    }
}
