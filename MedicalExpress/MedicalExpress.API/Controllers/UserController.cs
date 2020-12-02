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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userservice;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            ///inyeccion de dependencias
            _userservice = userService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var user = await _userservice.GetUsers();
            var userDto = _mapper.Map<IEnumerable<UserDto>>(user);

            var response = new ApiResponse<IEnumerable<UserDto>>(userDto);
            return Ok(response);
        }

        [HttpGet]
        [Route("login/{email}&{pass}")]
        public async Task<IActionResult> LoginUser(string email, string pass)
        {
            var user = await _userservice.LoginUser(email, pass);
            var userDto = _mapper.Map<IEnumerable<UserDto>>(user);

            var response = new ApiResponse<IEnumerable<UserDto>>(userDto);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userservice.GetUser(id);
            var userDto = _mapper.Map<UserDto>(user);


            var response = new ApiResponse<UserDto>(userDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Users(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            await _userservice.InsertUser(user);

            userDto = _mapper.Map<UserDto>(user);
            var response = new ApiResponse<UserDto>(userDto);

            return Ok(response);
        }


        [HttpPut]
        public async Task<IActionResult> Put(int id, UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.UserId = id;

            var result = await _userservice.UpdateUser(user);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userservice.DeleteUser(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }




    }
}
