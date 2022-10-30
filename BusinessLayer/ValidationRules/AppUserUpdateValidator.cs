using DTO.DTOs.AppUserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserUpdateValidator : AbstractValidator<AppUserUpdateDto>
    {
        public AppUserUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1,int.MaxValue).WithMessage("Id boş buraxıla bilməz !!!");
        }
    }
}
