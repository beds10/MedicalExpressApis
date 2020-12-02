using MedicalExpress.CORE.Entidades;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repositorios
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

    }
}
