using BE.TaskManagement.UseCases.Dtos.common;
using FluentValidation;

namespace BE.TaskManagement.UseCases.Validators.common
{
    public class PaginationRequestDtoValidator : AbstractValidator<PaginationRequestDto>
    {
        public PaginationRequestDtoValidator()
        {
            RuleFor(x => x.PageIndex).GreaterThanOrEqualTo(1).WithMessage("Define your error message");
            RuleFor(x => x.PageSize).GreaterThan(0).WithMessage("Define your error message");
        }
    }
}
