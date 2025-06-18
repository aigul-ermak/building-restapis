using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace DevHabit.DTOs.Tags;

public sealed record CreateTagDto
{
    //[Required]
    //[MinLength(3)]
    public required string Name { get; set; }
    //[MaxLength(3)]
    public string? Description { get; set; }
}

public sealed class CreateTagDtoValidator : AbstractValidator<CreateTagDto>
{
    public CreateTagDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3);
        RuleFor(x => x.Description).MaximumLength(50);
    }

}
