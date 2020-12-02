using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);
        Task<IEnumerable<User>> LoginUser(string email, string pass);
        Task InsertUser(User user);

        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(int id);
    }
}