using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IMethodPaymentService
    {
        Task<IEnumerable<MethodPayment>> GetMethods();
        Task<MethodPayment> GetMethod(int id);
        Task InsertMethod(MethodPayment method);
        Task<bool> UpdateMethod(MethodPayment method);
        Task<bool> DeleteMethod(int id);
    }
}