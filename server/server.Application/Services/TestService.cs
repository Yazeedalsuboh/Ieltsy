using AutoMapper;
using Microsoft.AspNetCore.Http;
using server.Application.Dtos;
using server.Application.Interfaces;
using server.Domain.Entities;
using server.Domain.Enums;
using server.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Application.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepo _testRepo;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TestService(ITestRepo testRepo, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _testRepo = testRepo;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<GetTestsDto>> GetTestsAsync(TypeEnum? typeEnum)
        {
            var baseUrl = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/";
            var entities = await _testRepo.GetAllAsync(typeEnum);

            var dtos = entities.Select(test => new GetTestsDto
            {
                Id = test.Id,
                Title = test.Title,
                Solved = test.Solved,
                Image = baseUrl + test.Image,
                Type = test.Type.ToString().ToLower()
            }).ToList();

            return dtos;
        }

        public async Task<TestDto?> GetTestAsync(int id)
        {
            var test = await _testRepo.GetByIdAsync(id);
            if (test == null)
                return null;

            var baseUrl = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/";

            var dto = new TestDto
            {
                Id = test.Id,
                Title = test.Title,
                Image = baseUrl + test.Image,
                Solved = test.Solved,
                UserAnswer = test.UserAnswer,
                Question = test.Question,
                Total = test.Total,
                EnhancedAnswer = test.EnhancedAnswer,
                Type = test.Type.ToString().ToLower()
            };

            return dto;
        }

        public async Task<bool> SubmitAnswerAsync(int id, AnswerTestDto dto)
        {
            var test = await _testRepo.GetByIdAsync(id);
            if (test == null)
                return false;

            test.Solved = true;
            test.EnhancedAnswer = dto.EnhancedAnswer;
            test.UserAnswer = dto.UserAnswer;
            test.Total = dto.Total; 

            await _testRepo.UpdateAsync(test);
            return true;
        }

        public async Task<bool> RetakeTestAsync(int id)
        {
            var test = await _testRepo.GetByIdAsync(id);
            if (test == null)
                return false;

            test.Solved = false;
            await _testRepo.UpdateAsync(test);

            return true;
        }
    }
}
