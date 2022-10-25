using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Valens_Survey_Management_API.Enums;
using ValensSurvey.Models;
using ValensSurvey.Services;

namespace ValensSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService _surveyService;

        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSurvey([FromBody] Survey survey)
        {
            var result = await _surveyService.Create(survey);

            return Ok(result);
        }
    }
}
