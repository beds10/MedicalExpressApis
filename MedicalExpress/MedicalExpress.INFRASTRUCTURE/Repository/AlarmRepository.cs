using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class AlarmRepository : IAlarmRepository
    {
        private readonly MedicalExpressDBContext _context;

        public AlarmRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Alarm>> GetAlarms()

        {
            var alarms = await _context.Alarma.ToListAsync();
            return alarms;
        }

        public async Task<Alarm> GetAlarm(int id)

        {
            var alarm = await _context.Alarma.FirstOrDefaultAsync(x => x.AlarmId == id);
            return alarm;
        }

        public async Task InsertAlarm(Alarm alarm)
        {
            _context.Alarma.Add(alarm);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAlarm(int id)
        {
            var currentalarm = await GetAlarm(id);
            _context.Alarma.Remove(currentalarm);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
