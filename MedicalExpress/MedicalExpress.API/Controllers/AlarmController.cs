using AutoMapper;
using MedicalExpress.API.Responses;
using MedicalExpress.CORE.DTOs;
using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.CORE.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MedicalExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmController : ControllerBase
    {
        private readonly IAlarmService _alarmservice;
        private readonly IMapper _mapper;

        public AlarmController(IAlarmService alarmService, IMapper mapper)
        {
            ///inyeccion de dependencias
            _alarmservice = alarmService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlarms()
        {
            var alarms = await _alarmservice.GetAlarms();
            var alarmsDto = _mapper.Map<IEnumerable<AlarmDto>>(alarms);

            var response = new ApiResponse<IEnumerable<AlarmDto>>(alarmsDto);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlarm(int id)
        {
            var alarm = await _alarmservice.GetAlarm(id);
            var alarmDto = _mapper.Map<AlarmDto>(alarm);

            var response = new ApiResponse<AlarmDto>(alarmDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AlarmDto alarmDto)
        {

            var alarm = _mapper.Map<Alarm>(alarmDto);

            await _alarmservice.InsertAlarm(alarm);
            alarmDto = _mapper.Map<AlarmDto>(alarm);
            var response = new ApiResponse<AlarmDto>(alarmDto);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _alarmservice.DeleteAlarm(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }


    }
}
