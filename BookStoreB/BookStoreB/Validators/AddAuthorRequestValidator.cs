using BookStore.Models.Request;
using FluentValidation;

namespace BookStoreB.Validators
{
    public class AddAuthorRequestValidator :
        AbstractValidator<AddAuthorRequest>
    {
        public AddAuthorRequestValidator()
        {
            RuleFor(x => x.Bio)
                .NotNull()
                .NotEmpty();
        }
    }
}
