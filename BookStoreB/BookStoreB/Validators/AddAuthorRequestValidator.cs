using BookStore.Models.Request;
using FluentValidation;

namespace BookStoreB.Validators
{
    public class AddAuthorRequestValidator :
        AbstractValidator<AddAuthorRequest>
    {
        public AddAuthorRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Pishi neshto")
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(10);
            RuleFor(x => x.Bio)
                .NotEmpty();
        }
    }
}
