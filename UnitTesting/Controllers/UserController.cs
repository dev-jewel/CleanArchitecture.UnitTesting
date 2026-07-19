using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTesting.Application.DTOs;
using UnitTesting.Application.Interfaces;
using UnitTesting.Domain.Entities;

namespace UnitTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUser")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userService.GetAllAsync());
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult>GetById(int id)
        {
            return Ok(await _userService.GetByIdAsync(id));
        }
        [HttpPost("CreateNew")]
        public async Task<IActionResult>Create(User model)
        {
            await _userService.AddAsync(model);
            return Ok( );
        }
        [HttpPut("UpdateUser")]
        public async Task<IActionResult>Update(User model)
        {
            await _userService.UpdateAsync(model);
            return Ok( );
        }
        [HttpDelete("DeleteUser/{id}")]
        public async Task<IActionResult>Delete(int id)
        {

           await _userService.DeleteAsync(id);
            return Ok();
        }
    
    }
}
