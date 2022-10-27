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
        public SurveyManagementController(ISurveyManagementService surveyManagementService)
        {
            _surveyManagementService = surveyManagementService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateSurveyManagement([FromBody] SurveyManagement surveyManagement)
        {
            var result = await _surveyManagementService.Create(surveyManagement);

            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _surveyManagementService.Get(id);

            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SurveyManagement surveyManagement)
        {
            var result = await _surveyManagementService.Update(surveyManagement);

            return Ok(result);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _surveyManagementService.Delete(id);

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
