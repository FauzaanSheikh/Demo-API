using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_API.Interfaces;
using Demo_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            try
            {
                var result = await _userService.Register(model);

                if (result != null)
                    return Ok(result);

                return BadRequest(new { message = "Registration failed" });
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginModel model)
        {
            try
            {
                var token = await _userService.Authenticate(model);

                if (!string.IsNullOrEmpty(token))
                    return Ok(new { token });

                return BadRequest(new { message = "Email or password is incorrect" });
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }
    }

}

