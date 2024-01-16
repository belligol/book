using BookStore.Models.Request;
using FluentValidation;

namespace BookStoreB.Validators
{
    public class AddBookRequestValidator :
        AbstractValidator<AddBookRequest>
    {
        public AddBookRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Ime zaduljitelno:")
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(10);
            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.AuthorId)
                 .NotNull()
                 .NotEmpty();
        }
    }
}
