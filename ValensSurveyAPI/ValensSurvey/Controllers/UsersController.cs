using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Valens_Survey_Management_API.Enums;
using ValensSurvey.Models;
using ValensSurvey.Services;

namespace ValensSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            var result = await _userService.Create(user);

            return Ok(result);
        }
    }
}
