using Domain.Users;
using FluentValidation;
using Microsoft.AspNetCore.Rewrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Validation
{
    public  class UserValidation : AbstractValidator<UserBaseEntity>
    {
             public UserValidation()
        {
            RuleFor(x=> x.Name).NotEmpty();
            RuleFor(x=> x.FriendsID).NotNull();
            RuleFor(x=> x.Email).NotNull().MaximumLength(50)
                .WithMessage(" You  are not writing many length ").MinimumLength(8)
                .WithMessage(" You are not writing little length ");
            RuleFor(x=> x.Password).MinimumLength(6).WithMessage(" Password is missing")
                .MaximumLength(15).WithMessage(" Password is multiple");
            RuleFor(x => x.ImageID).Null();

        }
    }
}
