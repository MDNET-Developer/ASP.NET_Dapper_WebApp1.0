using DTO.DTOs.EducationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class EducationAddDtoValidator:AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.StartDateTime).NotEmpty().WithMessage("Verilən daxil edin !!!");
            

        }
    }
}
