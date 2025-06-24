using server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Application.Dtos
{
    public class TypeEnumDto
    {
        [EnumDataType(typeof(TypeEnum), ErrorMessage = "Invalid status value")]
        public TypeEnum? Type { get; set; }
    }
}
