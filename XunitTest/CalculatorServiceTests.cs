using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace XunitTest
{
    public class CalculatorServiceTests
    {
     
        public CalculatorServiceTests() 
        {
            
        }

        //[Fact]
    //    public void CheckCalculator()
    //    {
    ////        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
    ////.UseInMemoryDatabase("TestDb")
    ////.Options;
    //        var cal = new CalculatorService();
    //        var res = cal.Add(2, 3);
    //        Assert.Equal(5, res);
    //    }
    //    [Fact]
    //    public async Task CheckIdWiseUser()
    //    {
    //        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
    //.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
    //.Options;
    //        var context = new ApplicationDbContext(options);
    //        context.Users.Add(new User
    //        {
    //            Id = 1,
    //            Name = "Jewel"
    //        });

    //        await context.SaveChangesAsync();
    //        var repository = new UserRepository(context);
    //        var user = await repository.GetByIdAsync(1);
    //        Assert.NotNull(user);
    //        Assert.Equal(1, user.Id);
    //        Assert.Equal("Jewel", user.Name);
    //    }
    }
}