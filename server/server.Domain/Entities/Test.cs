using server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Domain.Entities
{
    public class Test
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? Image { get; set; }

        public string Question { get; set; } = string.Empty;

        public bool Solved { get; set; } = false;

        public string UserAnswer { get; set; } = string.Empty;

        public string Total { get; set; } = string.Empty;

        public string EnhancedAnswer { get; set; } = string.Empty;

        public TypeEnum Type { get; set; }

    }
}
