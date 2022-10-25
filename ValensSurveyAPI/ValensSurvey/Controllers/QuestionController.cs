using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValensSurvey.Models;
using ValensSurvey.Services;

namespace ValensSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateSurvey([FromBody] Question question)
        {
            var result = await _questionService.Create(question);

            return Ok(result);
        }
    }
}
