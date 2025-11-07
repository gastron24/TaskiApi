using FluentValidation;
using TaskApi.Features.CreateTask;

namespace TaskApi.Features.CreateTask;

public class CreateTaskValidator : AbstractValidator<CreateTaskRequest>
{
    public CreateTaskValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(200).WithMessage("Title must be no more than 200 characters.");
    }
}