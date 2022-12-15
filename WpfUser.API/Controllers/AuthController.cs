using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WpfUser.API.Data;
using WpfUser.API.Dtos;

namespace WpfUser.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public AuthController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserDto? request)
        {
            if (!ModelState.IsValid || request is null)
            {
                return BadRequest();
            }

            var user = await _dbContext.Users.FirstOrDefaultAsync(u => 
                u.UserName.ToLower() == request.UserName.ToLower());

            if (user is null)
            {
                return NotFound();
            }

            if (request.Password != user.Password)
            {
                return BadRequest("Your username or password is not correct");
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDto? request)
        {
            if (!ModelState.IsValid || request is null)
            {
                return BadRequest();
            }

            var user = new User
            {
                UserName = request.UserName,
                Password = request.Password,
                DateOfBirth = request.DateOfBirth,
                Address = request.Address,
                Email = request.Email,
                Age = request.Age,
            };

            return Ok();
        }
    }
}
