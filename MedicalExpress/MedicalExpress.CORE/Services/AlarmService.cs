using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace MedicalExpress.CORE.Services
{
    public class AlarmService : IAlarmService
    {
        private readonly IAlarmRepository _alarmRepository;
        public AlarmService(IAlarmRepository alarmRepository)
        {
            _alarmRepository = alarmRepository;
        }

        public async Task<IEnumerable<Alarm>> GetAlarms()
        {
            return await _alarmRepository.GetAlarms();
        }

        public async Task<Alarm> GetAlarm(int id)
        {
            return await _alarmRepository.GetAlarm(id);
        }

        public async Task InsertAlarm(Alarm alarm)
        {
            await _alarmRepository.InsertAlarm(alarm);
        }
        public async Task<bool> DeleteAlarm(int id)
        {
            return await _alarmRepository.DeleteAlarm(id);
        }
    }
}
