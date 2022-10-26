﻿using Microsoft.AspNetCore.Http;
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
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _questionService.Get(id);

            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Question question)
        {
            var result = await _questionService.Update(question);

            return Ok(result);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _questionService.Delete(id);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _questionService.GetAll();

            return Ok(result);
        }
    }
}
