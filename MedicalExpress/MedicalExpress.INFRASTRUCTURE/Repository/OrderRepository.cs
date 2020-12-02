using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MedicalExpressDBContext _context;

        public OrderRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetOrders()

        {
            var orders = await _context.Orders.ToListAsync();
            return orders;
        }
        public async Task<IEnumerable<Order>> GetSessionToken(string id)

        {
            var products = await _context.Orders.Where(x => x.Session_token == id).ToListAsync();
            return products;
        }
        public async Task<IEnumerable<Order>> GetOrderByUser(int id)

        {
            var products = await _context.Orders.Where(x => x.UserOId == id).ToListAsync();
            return products;
        }
        public async Task<Order> GetOrder(int id)

        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.OrderId == id);
            return order;
        }

        public async Task InsertOrder(Order order)

        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            var currentorder = await GetOrder(order.OrderId);
            currentorder.Destination = order.Destination;
            currentorder.PharmOId = order.PharmOId;
            currentorder.UserOId = order.UserOId;
            currentorder.ProductOId = order.ProductOId;
            currentorder.StatusOId = order.StatusOId;
            currentorder.Session_token = order.Session_token;
            currentorder.Total_compra = order.Total_compra;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteOrder(int id)
        {
            var currentorder = await GetOrder(id);
            _context.Orders.Remove(currentorder);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
