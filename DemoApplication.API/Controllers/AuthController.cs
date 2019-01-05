using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoApplication.API.Data;
using Microsoft.EntityFrameworkCore;
using DemoApplication.API.Models;
using DemoApplication.API.DTOs;

namespace DemoApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserForRegisterDTO userForRegisterDTO)
        {
            //validate request
            userForRegisterDTO.Username = userForRegisterDTO.Username.ToLower();
            if (await _authRepository.UserExists(userForRegisterDTO.Username))
            {
                return BadRequest("UserName already exists");
            }

            var userToCreate = new User
            {
                UserName = userForRegisterDTO.Username
            };
            var createdUser = await _authRepository.Register(userToCreate, userForRegisterDTO.Password);
            return StatusCode(201);
        }
    }
}
