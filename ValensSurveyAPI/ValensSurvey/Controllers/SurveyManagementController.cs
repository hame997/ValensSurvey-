using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValensSurvey.Models;
using ValensSurvey.Services;

namespace ValensSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyManagementController : ControllerBase
    {
        private readonly ISurveyManagementService _surveyManagementService;
        private readonly IUserService _userService;
        private readonly ISurveyService _surveyService;
        public SurveyManagementController(ISurveyManagementService surveyManagementService, IUserService userService, ISurveyService surveyService)
        {
            _surveyManagementService = surveyManagementService;
            _userService = userService;
            _surveyService = surveyService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateSurveyManagement([FromBody] SurveyManagement surveyManagement)
        {
            try
            {
                User user = await _userService.Get(surveyManagement.UserId);                

                if(user == null)
                {
                    return NotFound("User does not exist !");
                }

                Survey survey = await _surveyService.Get(surveyManagement.SurveyId);

                if (survey == null)
                {
                    return NotFound("Survey does not exist !");
                }

                var result = await _surveyManagementService.Create(surveyManagement);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _surveyManagementService.Get(id);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _surveyManagementService.GetAll();

            return Ok(result);
        }
    }
}
