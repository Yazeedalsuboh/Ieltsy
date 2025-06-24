using server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Application.Dtos
{
    public class GetTestsDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Image { get; set; } = string.Empty;
        public bool Solved { get; set; } = false;
        public string Type { get; set; } = string.Empty;
    }
}
