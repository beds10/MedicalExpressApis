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
    public class MethodPaymentController : ControllerBase
    {
        private readonly IMethodPaymentService _methodservice;
        private readonly IMapper _mapper;

        public MethodPaymentController(IMethodPaymentService methodService, IMapper mapper)
        {
            ///inyeccion de dependencias
            _methodservice = methodService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMethods()
        {
            var methods = await _methodservice.GetMethods();
            var methodDto = _mapper.Map<IEnumerable<MethodPaymentDto>>(methods);

            var response = new ApiResponse<IEnumerable<MethodPaymentDto>>(methodDto);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetMethod(int id)
        {
            var method = await _methodservice.GetMethod(id);
            var methodDto = _mapper.Map<MethodPaymentDto>(method);

            var response = new ApiResponse<MethodPaymentDto>(methodDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MethodPaymentDto methodDto)
        {

            var method = _mapper.Map<MethodPayment>(methodDto);

            await _methodservice.InsertMethod(method);
            methodDto = _mapper.Map<MethodPaymentDto>(method);
            var response = new ApiResponse<MethodPaymentDto>(methodDto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, MethodPaymentDto methodDto)
        {
            var method = _mapper.Map<MethodPayment>(methodDto);
            method.PaymentId = id;

            var result = await _methodservice.UpdateMethod(method);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _methodservice.DeleteMethod(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
