using DTO.DTOs.SkillDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SkillAddDtoValidator:AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Verilən daxil edin !!!");
        }
    }
}
