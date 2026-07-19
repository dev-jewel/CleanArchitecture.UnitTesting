using Xunit;
using Moq;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using UnitTesting.Application.Interfaces;
using UnitTesting.Application.DTOs;
using UnitTesting.Controllers;
using UnitTesting.Domain.Entities;

namespace XunitTest.Controllers
{
    public class UserControllerTests
    {
        private readonly Mock<IUserService> _mockService;
        private readonly UserController _controller;


        public UserControllerTests()
        {
            _mockService = new Mock<IUserService>();

            _controller = new UserController(
                _mockService.Object
            );
        }


        [Fact]
        public async Task GetUser_Should_Return_Ok_When_User_Exists()
        {
            // Arrange

            var user = new User
            {
                Id = 1,
                Name = "Jewel"
            };


            _mockService
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(user);



            // Act

            var result = await _controller.GetById(1);



            // Assert

            var okResult = result.Should()
                .BeOfType<OkObjectResult>()
                .Subject;


            okResult.Value.Should()
                .BeEquivalentTo(user);
        }

        [Fact]
        public async void AddUser_Should_Return_Ok_After_Create_User()
        {
            var user = new User
            {
                Id = 1,
                Name = "Jewel"
            };
            _mockService
     .Setup(x => x.AddAsync(It.IsAny<User>()))
     .Returns(Task.CompletedTask);
            var result = await _controller.Create(user);
            result.Should()
      .BeOfType<OkResult>();
        }
        [Fact]
        public async Task GetAllUser_Should_Return_AllUser()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "Jewel", Email = "jeweltalukders53@gmail.com" },
                new User { Id = 2, Name = "J", Email = "j@gmail.com" }
            };
            _mockService.Setup(x => x.GetAllAsync()).ReturnsAsync(users);
            var res =await _controller.GetAll();
            var okResult= res.Should().BeOfType<OkObjectResult>().Subject;
            okResult.Value.Should().BeEquivalentTo(users);
        }
    }

}
