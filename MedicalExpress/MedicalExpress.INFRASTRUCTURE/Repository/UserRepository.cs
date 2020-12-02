using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MedicalExpressDBContext _context;


        public UserRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()

        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUser(int id)

        {
            var users = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            return users;
        }


        public async Task<IEnumerable<User>> LoginUser(string email, string pass)

        {
            var users = await _context.Users.Where(x => x.Email == email).Where(x => x.Pass == pass).ToListAsync();
            return users;
        }

        public async Task InsertUser(User user)

        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateUser(User user)
        {
            var currentuser = await GetUser(user.UserId);
            currentuser.Name = user.Name;
            currentuser.Email = user.Email;
            currentuser.Pass = user.Pass;
            currentuser.Direction = user.Direction;
            currentuser.NumberCellphone = user.NumberCellphone;
            currentuser.ProfileId = user.ProfileId;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var currentuser = await GetUser(id);
            _context.Users.Remove(currentuser);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
