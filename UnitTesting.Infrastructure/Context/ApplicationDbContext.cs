

using Microsoft.EntityFrameworkCore;
using UnitTesting.Domain.Entities;

namespace UnitTesting.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


    }
}
