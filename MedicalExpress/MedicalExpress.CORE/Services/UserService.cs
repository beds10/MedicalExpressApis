using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUser(int id)
        {
            return await _userRepository.GetUser(id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<IEnumerable<User>> LoginUser(string email, string pass)
        {
            return await _userRepository.LoginUser(email, pass);
        }

     
        public async Task InsertUser(User user)
        {
            await _userRepository.InsertUser(user);
        }

        public async Task<bool> UpdateUser(User user)
        {
            return await _userRepository.UpdateUser(user);
        }

        public async Task<bool> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }

    }
}
