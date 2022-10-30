﻿using DTO.DTOs.InterestDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class InterestUpdateDtoValidator:AbstractValidator<InterestUpdateDto>
    {
        public InterestUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id boş buraxıla bilməz !!!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Verilən daxil edin !!!");
        }
    }
}
