using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IAlarmService
    {
        Task<bool> DeleteAlarm(int id);
        Task<Alarm> GetAlarm(int id);
        Task<IEnumerable<Alarm>> GetAlarms();
        Task InsertAlarm(Alarm alarm);
    }
}