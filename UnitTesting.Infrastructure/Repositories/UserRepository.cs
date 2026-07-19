

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using UnitTesting.Application.Interfaces;
using UnitTesting.Domain.Entities;
using UnitTesting.Infrastructure.Context;

namespace UnitTesting.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var data = await _context.Users.FindAsync(id);
                if (data != null)
                {
                    _context.Users.Remove(data);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<User>> GetAllAsync()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Users.FindAsync(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task UpdateAsync(User user)
        {
            try
            {
                var data = await _context.Users.FindAsync(user.Id);
                if (data != null)
                {
                    data.Email = user.Email;
                    data.Name = user.Name;
                    _context.Users.Update(data);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //public async Task<User?> GetByIdAsync(int id)
        //{
        //    try
        //    {
        //        return await _context.Users.FindAsync(id);
        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }
        //}
        //public async Task AddAsync(User user)
        //{
        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();
        //}
    }
}
