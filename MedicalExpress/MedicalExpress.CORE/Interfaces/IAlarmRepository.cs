using MedicalExpress.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IAlarmRepository
    {

        Task<IEnumerable<Alarm>> GetAlarms();

        Task<Alarm> GetAlarm(int id);

        Task InsertAlarm(Alarm alarm);
        Task<bool> DeleteAlarm(int id);
    }
}
