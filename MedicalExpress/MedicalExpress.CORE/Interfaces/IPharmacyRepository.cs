using MedicalExpress.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IPharmacyRepository
    {
        Task<IEnumerable<Pharmacy>> GetPharmacies();

        Task<Pharmacy> GetPharmacy(int id);

        Task InsertPharmacy(Pharmacy pharmacy);
        Task<bool> UpdatePharmacy(Pharmacy pharmacy);
        Task<bool> DeletePharmacy(int id);
    }
}
