using MedicalExpress.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IDetailordRepository
    {
        Task<IEnumerable<Detailord>> GetDetailorders();

        Task<Detailord> GetDetailorder(int id);

        Task InsertDetail(Detailord detail);
        Task<bool> UpdateDetail(Detailord detail);
        Task<bool> DeleteDetail(int id);
    }
}
