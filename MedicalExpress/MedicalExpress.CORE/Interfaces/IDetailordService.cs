using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IDetailordService
    {
        Task<bool> DeleteDetail(int id);
        Task<Detailord> GetDetailorder(int id);
        Task<IEnumerable<Detailord>> GetDetailorders();
        Task InsertDetail(Detailord detail);
        Task<bool> UpdateDetail(Detailord detail);
    }
}