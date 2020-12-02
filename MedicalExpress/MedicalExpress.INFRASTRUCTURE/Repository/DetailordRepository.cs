using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class DetailordRepository : IDetailordRepository
    {
        private readonly MedicalExpressDBContext _context;

        public DetailordRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Detailord>> GetDetailorders()

        {
            var details = await _context.Detailords.ToListAsync();
            return details;
        }

        public async Task<Detailord> GetDetailorder(int id)

        {
            var detail = await _context.Detailords.FirstOrDefaultAsync(x => x.DetailId == id);
            return detail;
        }

        public async Task InsertDetail(Detailord detail)
        {
            _context.Detailords.Add(detail);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateDetail(Detailord category)
        {

            var currentcategorie = await GetDetailorder(category.DetailId);
            currentcategorie.quantity = category.quantity;
            currentcategorie.totalprice = category.totalprice;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteDetail(int id)
        {
            var currentdetails = await GetDetailorder(id);
            _context.Detailords.Remove(currentdetails);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
