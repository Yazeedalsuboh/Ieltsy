using server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Application.Dtos
{
    public class TestDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Image { get; set; } = string.Empty;
        public string Question { get; set; } = string.Empty;
        public bool Solved { get; set; } = false;
        public string UserAnswer { get; set; } = string.Empty;
        public string Total { get; set; } = string.Empty;
        public string EnhancedAnswer { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

    }
}
