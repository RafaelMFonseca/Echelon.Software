using FluentValidation;

namespace Echelon.Core.Models;

public record UserLoginRequestModel(string Email, string Password);

public class UserLoginRequestModelValidator : AbstractValidator<UserLoginRequestModel>
{
    public UserLoginRequestModelValidator()
    {
        RuleFor(x => x.Email).EmailAddress().NotEmpty().Length(256);
        RuleFor(x => x.Password).NotEmpty().Length(300);
    }
}