using DTO.DTOs.ExperienceDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceUpdateDtoValidator : AbstractValidator<ExperienceUpdateDto>
    {
        public ExperienceUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id boş buraxıla bilməz !!!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.StartDateTime).NotEmpty().WithMessage("Verilən daxil edin !!!");
        }
    }
}
