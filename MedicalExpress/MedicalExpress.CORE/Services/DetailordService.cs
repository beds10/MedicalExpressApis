using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public class DetailordService : IDetailordService
    {
        private readonly IDetailordRepository _detailRepository;
        public DetailordService(IDetailordRepository detailRepository)
        {
            _detailRepository = detailRepository;
        }

        public async Task<IEnumerable<Detailord>> GetDetailorders()
        {
            return await _detailRepository.GetDetailorders();
        }

        public async Task<Detailord> GetDetailorder(int id)
        {
            return await _detailRepository.GetDetailorder(id);
        }

        public async Task InsertDetail(Detailord detail)
        {
            await _detailRepository.InsertDetail(detail);
        }

        public async Task<bool> UpdateDetail(Detailord detail)
        {
            return await _detailRepository.UpdateDetail(detail);
        }

        public async Task<bool> DeleteDetail(int id)
        {
            return await _detailRepository.DeleteDetail(id);
        }
    }
}
