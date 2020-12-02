using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IPharmacyService
    {
        Task<IEnumerable<Pharmacy>> GetPharmacies();
        Task<Pharmacy> GetPharmacy(int id);
        Task InsertPharmacy(Pharmacy pharmacy);
        Task<bool> UpdatePharmacy(Pharmacy pharmacy);
        Task<bool> DeletePharmacy(int id);
    }
}