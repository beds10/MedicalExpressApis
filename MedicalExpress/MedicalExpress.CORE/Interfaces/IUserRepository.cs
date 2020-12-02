using MedicalExpress.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<User>> LoginUser(string email, string pass);
        Task<User> GetUser(int id);

        Task InsertUser(User user);
      
       Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(int id);
    }
}
