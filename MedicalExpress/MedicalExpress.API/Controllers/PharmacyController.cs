using AutoMapper;
using MedicalExpress.API.Responses;
using MedicalExpress.CORE.DTOs;
using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class PharmacyController : ControllerBase
    {
        private readonly IPharmacyService _pharmacyservice;
        private readonly IMapper _mapper;
        public PharmacyController(IPharmacyService pharmacyservice, IMapper mapper)
        {
            ///inyeccion de dependencias
            _pharmacyservice = pharmacyservice;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPharmacies()
        {
            var Pharms = await _pharmacyservice.GetPharmacies();
            var PharmsDto = _mapper.Map<IEnumerable<PharmacyDto>>(Pharms);
            var response = new ApiResponse<IEnumerable<PharmacyDto>>(PharmsDto);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPharmacy(int id)
        {
            var Pharm = await _pharmacyservice.GetPharmacy(id);
            var PharmsDto = _mapper.Map<PharmacyDto>(Pharm);

            var response = new ApiResponse<PharmacyDto>(PharmsDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Pharmacys(PharmacyDto pharmDto)
        {

            var pharm = _mapper.Map<Pharmacy>(pharmDto);

            await _pharmacyservice.InsertPharmacy(pharm);

            pharmDto = _mapper.Map<PharmacyDto>(pharm);
            var response = new ApiResponse<PharmacyDto>(pharmDto);

            return Ok(response);


        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, PharmacyDto pharmDto)
        {
            var pharm = _mapper.Map<Pharmacy>(pharmDto);
            pharm.PharmaId = id;

            var result = await _pharmacyservice.UpdatePharmacy(pharm);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _pharmacyservice.DeletePharmacy(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
