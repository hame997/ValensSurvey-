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
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _userService.Get(id);

            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] User user)
        {
            var result = await _userService.Update(user);

            return Ok(result);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userService.Delete(id);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetAll();

            return Ok(result);
        }
    }
}
