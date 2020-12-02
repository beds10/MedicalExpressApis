using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class MethodPaymentRepository : IMethodPaymentRepository
    {
        private readonly MedicalExpressDBContext _context;

        public MethodPaymentRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<MethodPayment>> GetMethods()

        {
            var methods = await _context.MethodPayments.ToListAsync();
            return methods;
        }

        public async Task<MethodPayment> GetMethod(int id)

        {
            var method = await _context.MethodPayments.FirstOrDefaultAsync(x => x.PaymentId == id);
            return method;
        }

        public async Task InsertMethod(MethodPayment method)
        {
            _context.MethodPayments.Add(method);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateMethod(MethodPayment method)
        {

            var currentmethod = await GetMethod(method.PaymentId);
            currentmethod.MethodName = method.MethodName;


            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteMethod(int id)
        {
            var currentmethod = await GetMethod(id);
            _context.MethodPayments.Remove(currentmethod);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
