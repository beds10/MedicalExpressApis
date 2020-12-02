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
    public class DetailordController : ControllerBase
    {
        private readonly IDetailordService _detailservice;
        private readonly IMapper _mapper;

        public DetailordController(IDetailordService detailService, IMapper mapper)
        {
            ///inyeccion de dependencias
            _detailservice = detailService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetDetailorders()
        {
            var detail = await _detailservice.GetDetailorders();
            var detailDto = _mapper.Map<IEnumerable<DetailordDto>>(detail);

            var response = new ApiResponse<IEnumerable<DetailordDto>>(detailDto);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetailorder(int id)
        {
            var detail = await _detailservice.GetDetailorder(id);
            var detailDto = _mapper.Map<DetailordDto>(detail);

            var response = new ApiResponse<DetailordDto>(detailDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DetailordDto detailDto)
        {

            var detail = _mapper.Map<Detailord>(detailDto);

            await _detailservice.InsertDetail(detail);
            detailDto = _mapper.Map<DetailordDto>(detail);
            var response = new ApiResponse<DetailordDto>(detailDto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, DetailordDto detailDto)
        {
            var detail = _mapper.Map<Detailord>(detailDto);
            detail.DetailId = id;

            var result = await _detailservice.UpdateDetail(detail);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _detailservice.DeleteDetail(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
