using BE.TaskManagement.Infrastructures.Constants;
using BE.TaskManagement.UseCases.Dtos.v1.HomePageDto;
using FluentValidation;

namespace BE.TaskManagement.UseCases.Validators.v1.HomePageValidator
{
    public class CreateTaskCategoryRequestDtoValidator : AbstractValidator<CreateTaskCategoryRequestDto>
    {
        public CreateTaskCategoryRequestDtoValidator()
        {
            RuleFor(task => task.Name)
                .NotEmpty().WithMessage(string.Format(ErrorMessageConstant.CannotBeNull, nameof(Domains.Entities.Task.Name)))
                .NotNull().WithMessage(string.Format(ErrorMessageConstant.CannotBeEmpty, nameof(Domains.Entities.Task.Name)))
                .MaximumLength(300).WithMessage(string.Format(ErrorMessageConstant.CannotBeLongerThan,
                    nameof(Domains.Entities.Task.Name),
                    300));

            RuleFor(task => task.Description)
                .NotEmpty().WithMessage(string.Format(ErrorMessageConstant.CannotBeNull, nameof(Domains.Entities.Task.Description)))
                .NotNull().WithMessage(string.Format(ErrorMessageConstant.CannotBeEmpty, nameof(Domains.Entities.Task.Description)))
                .MaximumLength(3000).WithMessage(string.Format(ErrorMessageConstant.CannotBeLongerThan,
                    nameof(Domains.Entities.Task.Description),
                    3000));
        }
    }
}
