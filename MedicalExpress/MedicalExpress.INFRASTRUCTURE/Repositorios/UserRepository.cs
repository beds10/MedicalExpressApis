using MedicalExpress.CORE.Entidades;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repositorios
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

        public async Task InsertUser(User user)

        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

    }
}
