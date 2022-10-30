using DTO.DTOs.InterestDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class InterestAddDtoValidator:AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Verilən daxil edin !!!");
        }
    }
}
