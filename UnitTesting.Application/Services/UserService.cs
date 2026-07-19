using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Application.Interfaces;
using UnitTesting.Domain.Entities;

namespace UnitTesting.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public  Task AddAsync(User user)
        {
            return  _userRepository.AddAsync(user);
        }

        public Task DeleteAsync(int id)
        {
            return _userRepository.DeleteAsync(id);
        }

        public Task<List<User>> GetAllAsync()
        {
            return _userRepository.GetAllAsync();
        }

        public Task<User?> GetByIdAsync(int id)
        {
            return _userRepository.GetByIdAsync(id);
        }

        public Task UpdateAsync(User user)
        {
            return _userRepository.UpdateAsync(user);
        }
    }
}
