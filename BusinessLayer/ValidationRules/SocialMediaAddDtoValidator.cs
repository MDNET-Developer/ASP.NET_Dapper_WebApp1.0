using DTO.DTOs.SocialMedia;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaAddDtoValidator:AbstractValidator<SocialMediaAddDto>
    {
        public SocialMediaAddDtoValidator()
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x=>x.Link).NotEmpty().WithMessage("Verilən daxil edin !!!");
        }
    }
}
