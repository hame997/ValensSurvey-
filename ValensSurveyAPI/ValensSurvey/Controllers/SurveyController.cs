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
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _surveyService.Get(id);

            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Survey survey)
        {
            var result = await _surveyService.Update(survey);

            return Ok(result);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _surveyService.Delete(id);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _surveyService.GetAll();

            return Ok(result);
        }
    }
}
