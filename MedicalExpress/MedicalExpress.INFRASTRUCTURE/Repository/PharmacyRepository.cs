using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class PharmacyRepository : IPharmacyRepository
    {
        private readonly MedicalExpressDBContext _context;

        public PharmacyRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pharmacy>> GetPharmacies()

        {
            var farmacias = await _context.Pharmacys.ToListAsync();
            return farmacias;
        }

        public async Task<Pharmacy> GetPharmacy(int id)

        {
            var farmacias = await _context.Pharmacys.FirstOrDefaultAsync(x => x.PharmaId == id);
            return farmacias;
        }

        public async Task InsertPharmacy(Pharmacy pharmacy)

        {
            _context.Pharmacys.Add(pharmacy);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePharmacy(Pharmacy pharmacy)
        {
            var currentpharm = await GetPharmacy(pharmacy.PharmaId);
            currentpharm.Name = pharmacy.Name;
            currentpharm.Longitude = pharmacy.Longitude;
            currentpharm.Latitude = pharmacy.Latitude;
            currentpharm.Adress = pharmacy.Adress;
            currentpharm.StatusPId = pharmacy.StatusPId;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeletePharmacy(int id)
        {
            var currentpharm = await GetPharmacy(id);
            _context.Pharmacys.Remove(currentpharm);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
