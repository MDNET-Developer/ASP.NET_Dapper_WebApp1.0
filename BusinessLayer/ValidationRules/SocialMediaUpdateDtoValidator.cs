using DTO.DTOs.SocialMedia;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaUpdateDtoValidator:AbstractValidator<SocialMediaUpdateDto>
    {
        public SocialMediaUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id boş buraxıla bilməz !!!");
        }
    }
}
