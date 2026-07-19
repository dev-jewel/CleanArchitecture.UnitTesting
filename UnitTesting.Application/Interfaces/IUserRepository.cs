
using UnitTesting.Domain.Entities;

namespace UnitTesting.Application.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(int id);

    Task<List<User>> GetAllAsync();

    Task AddAsync(User user);

    Task UpdateAsync(User user);

    Task DeleteAsync(int id);
}