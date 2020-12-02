using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public class PharmacyService : IPharmacyService
    {
        private readonly IPharmacyRepository _pharmacyRepository;
        public PharmacyService(IPharmacyRepository pharmacyRepository)
        {
            _pharmacyRepository = pharmacyRepository;
        }

        public async Task<Pharmacy> GetPharmacy(int id)
        {
            return await _pharmacyRepository.GetPharmacy(id);
        }

        public async Task<IEnumerable<Pharmacy>> GetPharmacies()
        {
            return await _pharmacyRepository.GetPharmacies();
        }

        public async Task InsertPharmacy(Pharmacy pharmacy)
        {
                     await _pharmacyRepository.InsertPharmacy(pharmacy);
        }

        public async Task<bool> UpdatePharmacy(Pharmacy pharmacy)
        {
            return await _pharmacyRepository.UpdatePharmacy(pharmacy);
        }

        public async Task<bool> DeletePharmacy(int id)
        {
            return await _pharmacyRepository.DeletePharmacy(id);
        }
    }
}
