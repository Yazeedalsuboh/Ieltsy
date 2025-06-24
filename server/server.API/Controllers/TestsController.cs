using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Application.Dtos;
using server.Application.Interfaces;
using server.Domain.Entities;
using server.Domain.Enums;
using System.Collections.Specialized;

namespace server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestsController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTests([FromQuery] TypeEnumDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var tests = await _testService.GetTestsAsync(dto.Type);
            var message = tests.Any() ? "Tests fetched successfully." : "No tests available.";
            return Ok(new { message, load = tests });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestAsync(int id)
        {
            var test = await _testService.GetTestAsync(id);
            if (test == null)
                return NotFound(new { message = "Test not found.", load = (object?)null });

            return Ok(new { message = "Test fetched successfully.", load = test });
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> SubmitAnswerAsync(int id, [FromBody] AnswerTestDto dto)
        {
            var success = await _testService.SubmitAnswerAsync(id, dto);
            if (!success)
                return NotFound(new { message = "Test not found.", load = (object?)null });

            return Ok(new { message = "Answer submitted successfully.", load = (object?)null });
        }

        [HttpPost("retake/{id}")]
        public async Task<IActionResult> RetakeTestAsync(int id)
        {
            var success = await _testService.RetakeTestAsync(id);
            if (!success)
                return NotFound(new { message = "Test not found.", load = (object?)null });

            return Ok(new { message = "Test marked as unsolved.", load = (object?)null });
        }
    }
}
