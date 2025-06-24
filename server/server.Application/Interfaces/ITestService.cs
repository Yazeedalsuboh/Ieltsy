using server.Application.Dtos;
using server.Domain.Entities;
using server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Application.Interfaces
{
    public interface ITestService
    {
        Task<List<GetTestsDto>> GetTestsAsync(TypeEnum? typeEnum);
        Task<TestDto> GetTestAsync(int id);
        Task<bool> SubmitAnswerAsync(int id, AnswerTestDto dto);
        Task<bool> RetakeTestAsync(int id);

    }
}
