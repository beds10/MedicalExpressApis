using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public class MethodPaymentService : IMethodPaymentService
    {
        private readonly IMethodPaymentRepository _methodRepository;
        public MethodPaymentService(IMethodPaymentRepository methodRepository)
        {
            _methodRepository = methodRepository;
        }

        public async Task<IEnumerable<MethodPayment>> GetMethods()
        {
            return await _methodRepository.GetMethods();
        }

        public async Task<MethodPayment> GetMethod(int id)
        {
            return await _methodRepository.GetMethod(id);
        }

        public async Task InsertMethod(MethodPayment method)
        {
            await _methodRepository.InsertMethod(method);
        }

        public async Task<bool> UpdateMethod(MethodPayment method)
        {
            return await _methodRepository.UpdateMethod(method);
        }

        public async Task<bool> DeleteMethod(int id)
        {
            return await _methodRepository.DeleteMethod(id);
        }
    }
}
